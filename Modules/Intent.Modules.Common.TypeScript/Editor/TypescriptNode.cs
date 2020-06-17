using System;
using System.Linq;
using Zu.TypeScript.Change;
using Zu.TypeScript.TsTypes;

namespace Intent.Modules.Common.TypeScript.Editor
{
    public abstract class TypeScriptNode
    {
        protected Node Node;
        public readonly TypeScriptFile File;
        public ChangeAST Change => File.Change;
        

        public TypeScriptNode(Node node, TypeScriptFile file)
        {
            Node = node;
            File = file;
        }

        public bool NodeExists(string path)
        {
            return FindNode(path) != null;
        }

        /// <summary>
        /// e.g. Decorator/CallExpression:NgModule/PropertyAssignment:providers/ArrayLiteralExpression
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Node FindNode(string path)
        {
            return FindNode(Node, path);
        }

        public Node FindNode(Node node, string path)
        {
            var pathParts = path.Split('/');
            var part = pathParts[0];

            var syntaxKindValue = part.Split(':')[0];
            var identifier = part.Split(':').Length > 1 ? part.Split(':')[1] : null;

            if (node == null || !Enum.TryParse(syntaxKindValue, out SyntaxKind syntaxKind))
                return null;

            if (pathParts.Length == 1)
            {
                return node.GetDescendants().OfKind(syntaxKind).FirstOrDefault(x => identifier == null || x.IdentifierStr == identifier);
            }

            if (identifier == null)
            {
                foreach (var descendant in node.GetDescendants().OfKind(syntaxKind))
                {
                    var found = FindNode(descendant, path.Substring(path.IndexOf("/", StringComparison.Ordinal) + 1));
                    if (found != null)
                    {
                        return found;
                    }
                }

                return null;
            }

            return FindNode(node.GetDescendants().OfKind(syntaxKind).FirstOrDefault(x => x.IdentifierStr == identifier), path.Substring(path.IndexOf("/", StringComparison.Ordinal) + 1));
        }

        public abstract bool IsIgnored();

        public void UpdateChanges()
        {
            if (IsIgnored())
            {
                throw new Exception($"Cannot add method to TypeScript node [{ToString()}] as it has been decorated with @IntentIgnore()");
            }
            File.UpdateChanges();
            Node = File.Ast.GetDescendants().OfKind(Node.Kind).Single(x => x.Pos == Node.Pos);
        }
    }
}