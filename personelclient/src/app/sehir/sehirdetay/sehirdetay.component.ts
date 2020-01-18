import { Component, OnInit, Input } from '@angular/core';
import { Sehir } from 'src/app/_Model/sehir';
import {FormGroup, FormBuilder, Validators} from '@angular/forms'; // FormGroupu tanıması için bunu import etmemiz gerekiyor.


@Component({
  selector: 'app-sehirdetay',
  templateUrl: './sehirdetay.component.html',
  styleUrls: ['./sehirdetay.component.css']
})
export class SehirdetayComponent implements OnInit {
  @Input() sehirInp: Sehir; // Bu değişken listeden detaya parametre verilmesi için tanımlanıyor.
  sehirForm: FormGroup; // projede listelediklerimizi forma dönüştürebilmek için bu değişkeni tanımladık.
  constructor(private formBuilder: FormBuilder) { }
  // form çalışabilmesi için form builder tanımlamamız gerekiyormus.
  ngOnInit() {
    this.createSehirForm(); // sayfa açıldığında direk formu yaratsın diye methodu buraya yazdık.
  }
createSehirForm() { // Form yaratması için bir method tanımladık.
  this.sehirForm = this.formBuilder.group({
    id: [''],
    ad: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]]
  });

}
}
