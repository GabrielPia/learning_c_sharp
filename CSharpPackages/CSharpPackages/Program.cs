using System.IO;
using CSharpPackages.KafkaService;

void readTextFile()
{
    string line;
    try
    {
        using (StreamReader sr = new StreamReader("names.txt"))
        {
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine($"File not found: {ex}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception ocurred while reading file: {e}");
    }
}

void writeTextFile()
{
    string[] names = new string[] { "Gabriel", "Vinicius", "Lucas" };
    try
    {
        using (StreamWriter sw = new StreamWriter(".\\names.txt"))
        {
            foreach (string s in names)
            {
                sw.WriteLine(s);
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception ocurred while reading file: {e}");
    }
}

//writeTextFile();
//readTextFile();

KafkaInitializer kafkaInitializer = new KafkaInitializer();

Thread consumerThread = new Thread(kafkaInitializer.initConsumer);
Thread producerThread = new Thread(kafkaInitializer.initProducer);

consumerThread.Start();
producerThread.Start();



Console.ReadLine();