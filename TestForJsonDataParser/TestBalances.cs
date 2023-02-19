namespace TestForJsonDataParser
{
    public class TestBalances
    {
       
        [Fact]
        public void TestGetJson()
        {

            Balance expected= new Balance() 
            {
                Account_id= 808251,
                Period= 202003,
                In_balance= 4176.03M,
                Calculation= 3206.69M
            };
            Balance actual= Balances.GetJson().DeserializedBalances.First(b=>b.Account_id==expected.Account_id);

            Assert.Equal(expected.Account_id, actual.Account_id);
            Assert.Equal(expected.In_balance, actual.In_balance);
            Assert.Equal(expected.Period, actual.Period);
            Assert.Equal(expected.Calculation, actual.Calculation);
            
        }
        [Fact]
        public void TestGetJsonCount()
        {
            FileInfo file = new FileInfo("D:\\Documents\\GitHub\\ЖилфондСервис\\JSON\\TestTaskForJKH\\JsonDataParser\\Models\\Data\\balance_202105270825.json");

            int expected = File.ReadAllLines(file.FullName).Where(s=>s.Contains("account_id")).Count();
            int actual = Balances.GetJson(file.Name).DeserializedBalances.Count;

            Assert.Equal(expected, actual);
           

        }
    }
}