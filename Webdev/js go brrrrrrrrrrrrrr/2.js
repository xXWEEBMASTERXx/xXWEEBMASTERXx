let tomb = [1,8,6,7,8,6,6,45,43,25,512]

// 1.feladat
function szamokatKivalogat(elem) {
    const szamok = ((elem) => typeof elem === "number");
    return szamok;
}
console.log(szamokatKivalogat([1,8,6,7,8,6,6,45,43,25,512]))
// 2.feladat
function szovegetOsszefuz(tomb) {
    const szoveg = tomb[0]+tomb[1]
    return szoveg;
}
console.log(szovegetOsszefuz(["bana","na"]))
// 3.feladat
function szepTomb(tomb) {
    const elsoElemTipusa = typeof tomb[0];
    for (const elem of tomb) {
      if (typeof elem !== elsoElemTipusa) {
        return false;
      }
    }
    return true;
}
console.log(szepTomb([1,"2"]))
// 4.feladat
function hatvanyoz(tomb, hatvany) {
    const eredmeny = tomb.map((elem) => elem ** hatvany);
    return eredmeny;
}
console.log(hatvanyoz(tomb,2))
// 5.feladat
function kisKaracsony(hetNap, napokSzama) {
    const hetNapokTömb = ["hetfo", "kedd", "szerda", "csutortok", "pentek", "szombat", "vasarnap"];
    return hetNapokTömb[karacsonyiNapok];
}
console.log(kisKaracsony())
// 6.feladat
function fullStack(frontend, backend) {
    const osszTomb = [...frontend, ...backend];
    for (const elem of osszTomb) {
      if (frontend.includes(elem) && backend.includes(elem)) {
        return [elem];
      }
    }
    return [];
}
console.log(fullStack())
// 7.feladat
function gepeles(szoveg) {
    const tisztaSzoveg = szoveg.replace(/\s+/g, "");
    if (tisztaSzoveg === "") {
      return "HIBA!";
    }
    const felhasznalokSzama = tisztaSzoveg.split(";").length;
    if (felhasznalokSzama === 1) {
      const felhasznalo = tisztaSzoveg.split(";")[0];
      return `${felhasznalo} eppen gepel...`;
    }
    if (felhasznalokSzama === 2) {
      const felhasznalok = tisztaSzoveg.split(";");
      return `${felhasznalok[0]} es ${felhasznalok[1]} eppen gepel...`;
    }
    const felhasznalok = tisztaSzoveg.split(";");
    return `${felhasznalok[0]}, ${felhasznalok[1]} es ${felhasznalokSzama - 2} tovabbi felhasznalo eppen gepel...`;
}
console.log(gepeles())
// 8.feladat
function otoslotto() {
    const szamok = [];
    while (szamok.length < 5) {
      const veletlenszam = Math.floor(Math.random() * 90) + 1;
      if (!szamok.includes(veletlenszam)) {
        szamok.push(veletlenszam);
      }
    }
    szamok.sort((a, b) => a - b);
    return szamok;
}
console.log(otoslotto())
// 9.feladat
function egyszamJatek(tomb) {
    const szamok = [];
    for (const elem of tomb) {
      if (!szamok.includes(elem)) {
        szamok.push(elem);
      }
    }
    if (szamok.length !== tomb.length) {
      return szamok[0];
    }
    return -1;
}
console.log(egyszamJatek())
// 10.feladat
function emailCimGenerator(teljesNev, szuletesiEv = 2000) {
    const tisztaNev = teljesNev.replace(/\s+/g, "");
    const szulEvStr = szuletesiEv.toString();
    const emailCim = `${tisztaNev.substring(0, 3)}${szulEvStr.substring(szulEvStr.length - 2)}@dhk.hu`;
    return emailCim;
}
console.log(emailCimGenerator())
// 11.feladat
function fajlRendezo(fajlnevek) {
    const pyFajlok = [];
    const jsFajlok = [];
    const egyebFajlok = [];
    for (const fajlnev of fajlnevek) {
      const [nev, kiterjesztes] = fajlnev.split(".");
      switch (kiterjesztes.toLowerCase()) {
        case "py":
          pyFajlok.push(nev);
          break;
        case "js":
          jsFajlok.push(nev);
          break;
        default:
          egyebFajlok.push(nev);
          break;
      }
    }
    return [[...pyFajlok], [...jsFajlok], [...egyebFajlok]];
  }
console.log(fajlRendezo())