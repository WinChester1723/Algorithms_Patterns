namespace Algorithms_Patterns.Patterns.Generative_Patterns.Builder
{
    internal class Product
    {
       private List<object> _parts = new List<object>();

        public void Add(string parts)
        {
            this._parts.Add(parts);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for(int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Product parts: " + str + "\n";
        }
    }
}