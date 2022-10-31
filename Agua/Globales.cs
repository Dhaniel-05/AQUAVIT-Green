using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public static class Globales
{
	public static Globales
	{
		 public static SqlConnection conexion = new SqlConnection("Data Source = (Local)\\SqlExpress; Initial Catalog = Agua; Integrated Security = True");
    //
    static readonly string key = "5555";
    //
    static public string DocUsuario = string.Empty;
    static public string DocActual = string.Empty;

    internal static void LlenarComboBoxPropietario1()
    {
        throw new NotImplementedException();
    }

    static public string RolActual = string.Empty;
    static public string UsuarioActual = string.Empty;
    //
    static public string DocPropietario = string.Empty;
    static public string DocActualP = string.Empty;
    static public string UsuarioActualP = string.Empty;
    //
    static public string NomEstrato = string.Empty;
    static public string EstratoActual = string.Empty;
    //
    static public string NomBarrio = string.Empty;
    static public string BarrioActual = string.Empty;
    static public string NoBarrio = string.Empty;
    static public string NoBarrio1 = string.Empty;
    //
    static public string NoIdPredio = string.Empty;
    static public string NoPropietario = string.Empty;
    static public string CatastroActual = string.Empty;


    public static string Encriptar(string texto)
    {
        //arreglo de bytes donde guardaremos la llave
        byte[] keyArray;
        //arreglo de bytes donde guardaremos el texto
        //que vamos a encriptar
        byte[] Arreglo_a_Cifrar =
        UTF8Encoding.UTF8.GetBytes(texto);

        //se utilizan las clases de encriptación
        //provistas por el Framework
        //Algoritmo MD5
        MD5CryptoServiceProvider hashmd5 =
        new MD5CryptoServiceProvider();
        //se guarda la llave para que se le realice
        //hashing
        keyArray = hashmd5.ComputeHash(
        UTF8Encoding.UTF8.GetBytes(key));

        hashmd5.Clear();

        //Algoritmo 3DAS
        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

        tdes.Key = keyArray;
        tdes.Mode = CipherMode.ECB;
        tdes.Padding = PaddingMode.PKCS7;

        //se empieza con la transformación de la cadena
        ICryptoTransform cTransform =
        tdes.CreateEncryptor();

        //arreglo de bytes donde se guarda la
        //cadena cifrada
        byte[] ArrayResultado =
        cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
        0, Arreglo_a_Cifrar.Length);

        tdes.Clear();

        //se regresa el resultado en forma de una cadena
        return Convert.ToBase64String(ArrayResultado,
        0, ArrayResultado.Length);
    }

    public static string Desencriptar(string textoEncriptado)
    {
        byte[] keyArray;
        //convierte el texto en una secuencia de bytes
        byte[] Array_a_Descifrar =
        Convert.FromBase64String(textoEncriptado);

        //se llama a las clases que tienen los algoritmos
        //de encriptación se le aplica hashing
        //algoritmo MD5
        MD5CryptoServiceProvider hashmd5 =
        new MD5CryptoServiceProvider();

        keyArray = hashmd5.ComputeHash(
        UTF8Encoding.UTF8.GetBytes(key));

        hashmd5.Clear();

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

        tdes.Key = keyArray;
        tdes.Mode = CipherMode.ECB;
        tdes.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform =
        tdes.CreateDecryptor();

        byte[] resultArray =
        cTransform.TransformFinalBlock(Array_a_Descifrar,
        0, Array_a_Descifrar.Length);

        tdes.Clear();
        //se regresa en forma de cadena
        return UTF8Encoding.UTF8.GetString(resultArray);
    }

    public static void LlenarComboBoxEstrato(AgregarBarrio x)
    {
        SqlCommand cmd = new SqlCommand("SELECT IdEstrato, Estrato FROM Estratos", conexion);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        x.idEstratoComboBox.DisplayMember = "Estrato";
        x.idEstratoComboBox.ValueMember = "IdEstrato";
        x.idEstratoComboBox.DataSource = dt;
    }

    public static void LlenarComboBoxEstrato1(EditarBarrio x)
    {
        SqlCommand cmd = new SqlCommand("SELECT IdEstrato, Estrato FROM Estratos", conexion);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        x.idEstratoComboBox.DisplayMember = "Estrato";
        x.idEstratoComboBox.ValueMember = "IdEstrato";
        x.idEstratoComboBox.DataSource = dt;
    }

    public static void LlenarComboPropietario(AgregarPredio x)
    {
        SqlCommand cmd = new SqlCommand("SELECT IdPropietario, Nombre FROM Propietarios", conexion);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        x.IdPropietarioComboBox.DisplayMember = "Nombre";
        x.IdPropietarioComboBox.ValueMember = "IdPropietario";
        x.IdPropietarioComboBox.DataSource = dt;
    }

    public static void LlenarComboBoxPropietario1(EditarPredio x)
    {
        SqlCommand cmd = new SqlCommand("SELECT IdPropietario, Nombre FROM Propietarios", conexion);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        x.IdPropietarioComboBox.DisplayMember = "Nombre";
        x.IdPropietarioComboBox.ValueMember = "IdPropietario";
        x.IdPropietarioComboBox.DataSource = dt;
    }

    public static void LlenarComboBarrio(AgregarPredio x)
    {
        SqlCommand cmd = new SqlCommand("SELECT IdBarrio, NombreBarrio FROM Barrios", conexion);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        x.IdBarrioComboBox.DisplayMember = "NombreBarrio";
        x.IdBarrioComboBox.ValueMember = "IdBarrio";
        x.IdBarrioComboBox.DataSource = dt;
    }

    public static void LlenarComboBoxBarrio1(EditarPredio x)
    {
        SqlCommand cmd = new SqlCommand("SELECT IdBarrio, NombreBarrio FROM Barrios", conexion);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        x.IdBarrioComboBox.DisplayMember = "NombreBarrio";
        x.IdBarrioComboBox.ValueMember = "IdBarrio";
        x.IdBarrioComboBox.DataSource = dt;
        }
    }
}
