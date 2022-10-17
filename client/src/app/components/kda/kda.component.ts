import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-kda',
  templateUrl: './kda.component.html',
  styleUrls: ['./kda.component.scss']
})
export class KdaComponent implements OnInit {
  @Input() kills: number;
  @Input() assists: number;
  @Input() deaths: number;

  constructor() { }

  ngOnInit() {
  }

  getKDA(kills: number, assists: number, deaths: number) {
    if (!deaths) {
      return kills + assists;
    }

    const kda = (kills + assists) / deaths;
    return kda.toFixed(2);
  }
}
