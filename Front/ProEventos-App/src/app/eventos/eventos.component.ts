import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
})
export class EventosComponent implements OnInit {
  public eventos: any = [
    {
      Tema: 'Angular 11',
      Local: 'Belo Horizonte',
    },
    {
      Tema: '.Net',
      Local: 'São Paulo',
    },
    {
      Tema: 'Angular 12',
      Local: 'Rio de Janeiro',
    },
  ];

  constructor() { }

  ngOnInit(): void { }
}
