namespace ScreenSound.Menu;

internal class MenuRegistrarBanda : Menu
{
      public override void Executar(Dictionary<string, List<int>> bandasRegistradas)
      {
            {
                  base.Executar(bandasRegistradas);
                  ExibirTituloDaOpcao("Registro das bandas");
                  Console.Write("Digite o nome da banda que deseja registrar: ");
                  string nomeDaBanda = Console.ReadLine()!;
                  bandasRegistradas.Add(nomeDaBanda, new List<int>());
                  Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
                  Thread.Sleep(4000);
                  Console.Clear();
                  
            }
      }
}