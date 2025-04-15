namespace ScreenSound.Menu;

internal class MenuRegistrarAlbum : Menu
{
      public override void Executar(Dictionary<string, List<int>> bandasRegistradas)
      {
            {
                  base.Executar(bandasRegistradas);
                  ExibirTituloDaOpcao("Registro de álbuns");
                  Console.Write("Digite a banda cujo álbum deseja registrar: ");
                  string nomeDaBanda = Console.ReadLine()!;
                  Console.Write("Agora digite o título do álbum: ");
                  string tituloAlbum = Console.ReadLine()!;
                  if (bandasRegistradas.ContainsKey(nomeDaBanda))
                  {
                        bandasRegistradas[nomeDaBanda].Add(tituloAlbum.Length);
                  }
                  else
                  {
                        Console.WriteLine("Banda não registrada.");
                        Thread.Sleep(2000);
                        Console.Clear();

                        return;
                  }
                  Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                  Thread.Sleep(4000);
                  Console.Clear();
            }
      }
}