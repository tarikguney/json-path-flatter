class Program{
  public static void Main()
  {
    var content = File.ReadAllText(@"C:\Users\Tarik Guney\Desktop\sample.json");
    var children = JObject.Parse(content).Children();

    var list = new List<string>();

    OutputPath(children);
  }

  private void OutputPath(JEnumerable<JToken> children)
  {
    foreach (var child in children)
    {
      if (child.Children().Any())
      {
        OutputPath(child.Children());
      }
      else
      {
        var message = @"
          {
            ""from"": ""{from}"",
            ""to"":""""
          },";

        if (child.Path.Contains("["))
        {
          Console.WriteLine(RemoveArrayIndexNumbers(message.Replace("{from}", child.Path)));
        }
        else
        {
          Console.WriteLine(message.Replace("{from}", child.Path));
        }
      }
    }
  }

  private string RemoveArrayIndexNumbers(string path)
  {
    return Regex.Replace(path, @"\[*.\]", "[]");
  }
}
