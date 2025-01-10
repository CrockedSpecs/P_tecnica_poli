using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;  // Asegúrate de agregar este namespace

public class randomValues : MonoBehaviour
{
    public TextMeshProUGUI materiaPrima;
    public TextMeshProUGUI ManoDeObra;
    public TextMeshProUGUI CIF;
    public TextMeshProUGUI Utilidad;

    public TMP_InputField totalCost;
    public TMP_InputField utilidadEsperada;
    public TMP_InputField PrecioVenta;
    public TextMeshProUGUI resultText;
    public int verificacion;
    public Button comprobarButton;


    private int randomMateriaPrima;
    private int randomManoDeObra;
    private int randomCIF;
    private float randomUtilidad;

    // Start is called before the first frame update
    void Start()
    {
        randomMateriaPrima = Random.Range(100000, 500001);
        randomManoDeObra = Random.Range(100000, 500001);
        randomCIF = Random.Range(100000, 500001);
        randomUtilidad = Random.Range(0.50f, 1.20f);

        materiaPrima.text = ("Materia Prima por unidad: $" + randomMateriaPrima.ToString());
        ManoDeObra.text = ("Mano de Obra por unidad: $" + randomManoDeObra.ToString());
        CIF.text = ("CIF por unidad: $" + randomCIF.ToString());
        Utilidad.text = ("Utilidad: " + (randomUtilidad * 100).ToString() + "%");

        comprobarButton.onClick.AddListener(ComprobarValores);
    }

    public void ComprobarValores()
    {
        float costoTotalUsuario = float.Parse(totalCost.text);
        float utilidadEsperadaUsuario = float.Parse(utilidadEsperada.text);
        float precioVentaUsuario = float.Parse(PrecioVenta.text);

        float costoTotalCorrecto = randomMateriaPrima + randomManoDeObra + randomCIF;
        float utilidadEsperadaCorrecta = randomUtilidad * costoTotalCorrecto;
        float precioVentaCorrecto = costoTotalCorrecto + utilidadEsperadaCorrecta;

        string resultado = "Resultados de la comprobación:\n";

        if (costoTotalUsuario==costoTotalCorrecto)
        {
            resultado += "Costo Total por unidad: CORRECTO\n";
        }
        else
        {
            resultado += $"Costo Total por unidad: INCORRECTO. El valor correcto es: ${costoTotalCorrecto}\n";
        }

        if (Mathf.Approximately(utilidadEsperadaUsuario,utilidadEsperadaCorrecta))
        {
            resultado += "Utilidad esperada por unidad: CORRECTO\n";
        }
        else
        {
            resultado += $"Utilidad esperada por unidad: INCORRECTO. El valor correcto es: ${utilidadEsperadaCorrecta}\n";
        }

        if (Mathf.Approximately(precioVentaUsuario,precioVentaCorrecto))
        {
            resultado += "Precio de venta: CORRECTO\n";
        }
        else
        {
            resultado += $"Precio de venta: INCORRECTO. El valor correcto es: ${precioVentaCorrecto}\n";
        }
        resultText.text = resultado;
    }
}
