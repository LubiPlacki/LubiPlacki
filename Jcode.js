document.getElementById('Guzik').addEventListener('click', function() {
    imie=document.getElementById('imie').value;
    nazwisko=document.getElementById('nazwisko').value;
    oko=document.querySelector('input[name="oczy"]:checked').value;
    if(imie=="" || nazwisko==""){
        alert("wprowadz imie i nazwisko");
    } else {
    alert(imie+" "+nazwisko+" oczy "+oko);}
});

function Obrazki(){
    numerek=document.getElementById('numer').value;
    document.getElementById('obrazek2').src="zdjecie-"+numerek+".jpg";
    document.getElementById('obrazek1').src="odcisk-"+numerek+".jpg";
    
}