using Send_Json;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Nodes;

var url = "https://api-prod.humand.co/public/api/v1/users";
var apiToken = "Basic m19chPcEgXxAkXLfpNOxK9DLq7QP2vpA";

//Crear la lista de usuarios a enviar
var user = new Users
{


        password = "Bodesa123",

        relationships = new List<Relationships>
        {
            new Relationships
            {
                name = "BOSS",
                employeeInternalId = "60010862"
            }
        },

        employeeInternalId = "60010902",
        firstName = "Jorge",
        lastName = "Mendoza"
};

//creamos objeto http
var client = new HttpClient();

client.DefaultRequestHeaders.Add("Authorization", apiToken);

var data = JsonSerializer.Serialize<Users>(user);

var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

var response = new HttpResponseMessage();

response = await client.PostAsync(url, content);

//obetenemos la respuesta
 
var respuesta = await response.Content.ReadAsStringAsync();

//Verificar si salio correcto
if (response.IsSuccessStatusCode)
{
    Console.WriteLine("Envio de usuarios exitoso");
    Console.WriteLine(respuesta);
 }
else
{
    Console.WriteLine("Error al enviar los usuarios");
    Console.WriteLine(respuesta);
 }






