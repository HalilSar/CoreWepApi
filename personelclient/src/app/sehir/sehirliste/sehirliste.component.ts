import { Component, OnInit } from '@angular/core';
import { Sehir } from 'src/app/_Model/sehir';
import { SehirService } from 'src/app/_services/sehir.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-sehirliste',
  templateUrl: './sehirliste.component.html',
  styleUrls: ['./sehirliste.component.css']
})
export class SehirlisteComponent implements OnInit {

slist: Sehir[];
secSehir: Sehir ;
  constructor(private sehirservice: SehirService, http: HttpClient ) {}
  ngOnInit() {
    this.getsehirler();
  }
getsehirler() {
  this.sehirservice.getSehirler().subscribe((sehirler: Sehir[]) => {
    this.slist = sehirler;
    console.log(this.slist);
  },
  err => {
    console.log(err);
  }
  );
}
getSehir(sehir: Sehir) {
  this.secSehir = sehir;
}
}
