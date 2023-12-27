/*

try 
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    } 
} 

catch (FileNotFoundException ex)
{
    Console.WriteLine($"O arquivo não foi encontrado. {ex.Message}");
}

catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Houve um erro no caminho do arquivo. A pasta não foi encontrada. {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma excecão genérica. {ex.Message}");
}

finally // o bloco finally sempre será executado, se tiver exceção ou não. É útil para fechar conexões com banco.
{
    Console.WriteLine($"Chegou até aqui.");
}

*/