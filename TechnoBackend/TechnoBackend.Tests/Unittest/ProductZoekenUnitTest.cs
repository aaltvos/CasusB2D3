using System;

public class ProductZoekenUnitTest
{
    [TestMethod]
    public void UnitTestProductZoeken()
    {
        //Calls the test method login to obtain a token so i get access to see events
        var token = UsecaseLogin.TestMethodLogin();

        //Creates a request to see all the events, the login token will be sended also to verify that user is allowed to see it
        var test_UnitTestProductZoeken = WebRequest.CreateHttp("http://localhost:51516/api/ProductZoeken");
        test_UnitTestProductZoeken.Method = "GET";
        test_UnitTestProductZoeken.Headers.Add("Token", token);

        //Obtains the event_list from the class ShowEvents and is stored as variable: response
        var response = test_UnitTestProductZoeken.GetResponse();

        //The event_list gets encoded so its readable and is stored as variable: responseText
        var encoding = Encoding.UTF8;
        var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding);
        string responseText = reader.ReadToEnd();

        //The variable: responseText gets changed to a array so its possible to count the search amount
        //The counted outcome will be stored in variable: expected


        //Here will be checked if the amount of the returned event_list is correct
        Assert.AreEqual(3, expected);
    }
}
    