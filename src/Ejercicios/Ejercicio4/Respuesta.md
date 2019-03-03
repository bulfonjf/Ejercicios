# Ejercicio 4

## ¿Hay algún problema con el código siguiente?

void ProcesarUsuario(string connectionString, string userId, string password)
{
    SqlConnection sqlConnection1 = new SqlConnection(connectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader reader;
    string query = "SELECT * FROM users WHERE userId = '" + userId + "' AND password = '" + password + "'";
    cmd.CommandText = query;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    while(reader.Read())
    {
        ...
    }
    sqlConnection1.Close();        
}

## Respuesta

- El método realiza más de una responsabilidad, por ejemplo crear la conexión con la base de datos, ejecutar una consulta y leerla.
- Si la password no está encriptada sería otro punto a mejorar.
- La consulta SQL está escrita dentro del método.
- No se está liberando el objeto reader. Para ello se puede usar un bloque using.
- No se verifica que el objeto reader tenga rows. Se puede usar la propiedad HasRows del objeto reader.
- No se manejan excepciones.
- La conexión no va a cerrarse si ocurre una excepción antes de "sqlConnection1.Close();", es por ello es que se usa un bloque try catch finally. En el bloque finally tendría que ir el código mencionado.
