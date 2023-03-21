Lag et konsoll-program som heter PasswordGenerator. Hvis det kalles uten kommandolinjeparametre (args[]), 
skal du vise teksten under og avslutte:
PasswordGenerator  
  Options:
  - l = lower case letter
  - L = upper case letter
  - d = digit
  - s = special character (!"#¤%&/(){}[]
Example: PasswordGenerator 14 lLssdd
         Min. 1 lower case
         Min. 1 upper case
         Min. 2 special characters
         Min. 2 digits
Hvis det er akkurat to kommandolinjeparametre, skal du også sjekke om den første bare inneholder sifre. Hvis den inneholder noe annet, skal du vise teksten vist i forrige punkt og avslutte. 
Hvis du har en string s, kan du lage en foreach( var c in s) - og den vil da kjøre for hvert tegn i stringen. Bruk char.IsDigit(c) til å avgjøre om et tegn er et siffer eller ikke. 

Sjekk også den andre kommandolinjeparameteren. Den skal ikke inneholde noe annet enn stor eller liten L, d eller s. Hvis den inneholder noe annet, skal du vise samme tekst som tidligere og avslutte. 
Du kan sammenligne med et bestemt tegn på denne måten: if(c == 'x')

Samle nå all validering i en egen metode IsValid() som returnerer true hvis alt er i orden og false ellers. Lag også en egen metode ShowHelpText() som viser den nevnte teksten. Begynnelsen på Main() skal nå være slik:
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }

Lag en string med navn pattern og sett den til mønsteret brukeren har angitt som kommandolinjeparameter (args[1]). 
Sørg for at den blir like lang som passordlengden brukeren ønsker (args[0]) ved å fylle opp med små L-er. Bruk google til å finne ut "c# pad string". 

Lag en while-løkke som kjører så lenge pattern sin lengde er 1 eller høyere. Inne i løkken fjerner du siste tegn, og basert på dette kaller du en av de følgende metodene: WriteRandomLowerCaseLetter(), WriteRandomUpperCaseLetter(), WriteRandomDigit() og WriteRandomSpecialCharacter(). Lag en enkel versjon av hver av dem som bare skriver ut et hardkodet tegn (f.eks. 'x', 'Z', '5', '!')

Legg til static readonly Random Random = new Random(); før Main(). Nå kan du få et tilfeldig tall som er minimum f.eks. 5 og maksimum 15 ved å skrive Random.Next(5,15). Bruk dette til å fullføre WriteRandomDigit(). 

Fullfør metodene som skriver ut bokstaver. Du kan bruke denne hjelpemetoden hvis du vil:
  static char GetRandomLetter(char min, char max)
  {
      return (char)Random.Next(min, max);
  }
Fullfør den siste som lager spesialtegn ved å lage en string som inneholder alle spesialtegnene du vil ha med. Finn så et tilfeldig tall mellom 0 og lengden på denne stringen. Bruk tallet som indeks og hent ut riktig tegn ved å bruke stringen som en array av tegn - eller substring. 

Endre programmet så det ikke tar siste tegn hver gang inne i while-løkken, men en tilfeldig posisjon. Bruk f.eks. substring til å lag en ny string som er lik den du hadde, men hvor tegnet du har valgt ut er fjernet. 