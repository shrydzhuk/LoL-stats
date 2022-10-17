import { Component, Input, OnInit } from '@angular/core';
import { ISummonerChampion } from 'src/app/models/champions/summonerChampion';

@Component({
  selector: 'app-champion-details',
  templateUrl: './champion-details.component.html',
  styleUrls: ['./champion-details.component.scss']
})
export class ChampionDetailsComponent implements OnInit {
  @Input() champion: ISummonerChampion;
  
  constructor() { }

  ngOnInit() {
  }

}
