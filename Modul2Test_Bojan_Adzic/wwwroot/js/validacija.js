function validacija() {
    // Deklaracija promenljivih za input polja:
    let naziv = document.getElementById("Naziv").value;
    let brojGodinaGarancije = document.getElementById("BrojGodinaGarancije").value;
    let cena = document.getElementById("Cena").value;
    let tip = document.getElementById("Tip").value;

    // Deklaracija promenljivih za validacioni ispis
    let nazivGreska = document.getElementById("NazivGreska");
    let brojGodinaGarancijeGreska = document.getElementById("BrojGodinaGarancijeGreska");
    let cenaGreska = document.getElementById("CenaGreska");
    let tipGreska = document.getElementById("TipGreska");

    // Deklaracija povratne boolean promenljive
    let isValid = true;

    // Inicijalna dodela vrednosti validacionih promenljivih
    nazivGreska.innerHTML = "";
    brojGodinaGarancijeGreska.innerHTML = "";
    cenaGreska.innerHTML = "";
    tipGreska.innerHTML = "";

    // If statement za proveru polja Naziv
    if (!naziv) {
        nazivGreska.innerHTML = "Obavezno polje (klijent)";
        isValid = false;
    }

    // If statement za proveru polja BrojGodinaGarancije
    if (!brojGodinaGarancije) {
        brojGodinaGarancijeGreska.innerHTML = "Obavezno polje (klijent)";
        isValid = false;
    } else if (brojGodinaGarancije < 1 || brojGodinaGarancije > 10) {
        brojGodinaGarancijeGreska.innerHTML = "Godina garancije mora biti od 1 do 10 (klijent)";
        isValid = false;
    }

    // If statement za proveru polja Cena

    if (!cena) {
        cenaGreska.innerHTML = "Obavezno polje (klijent)";
        isValid = false;
    } else if (cena < 10000 || cena > 500000) {
        cenaGreska.innerHTML = "Cena mora biti u rasponu izmedju 10 000 i 500 000 (klijent)";
        isValid = false;
    }

    // If statement za proveru polja Tip
    if (!tip) {
        tipGreska.innerHTML = "Obavezno polje (klijent)";
        isValid = false;
    } else if (tip.length > 30) {
        tipGreska.innerHTML = "Tip ne sme biti duzi od 30 karaktera (klijent)";
        isValid = false;
    }

    return isValid;
}