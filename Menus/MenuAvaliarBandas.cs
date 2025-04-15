namespace ScreenSound.Menu;

internal class MenuAvaliarBandas : Menu
{
      public override void Executar(Dictionary<string, List<int>> bandasRegistradas)
      {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                  Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                  int nota = int.Parse(Console.ReadLine()!);
                  bandasRegistradas[nomeDaBanda].Add(nota);
                  Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                  Thread.Sleep(2000);
                  Console.Clear();
            }
            else
            {
                  Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                  Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                  Console.ReadKey();
                  Console.Clear();
            }
      }
}