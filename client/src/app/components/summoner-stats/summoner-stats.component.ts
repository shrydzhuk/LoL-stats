import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-summoner-stats',
  templateUrl: './summoner-stats.component.html',
  styleUrls: ['./summoner-stats.component.scss']
})
export class SummonerStatsComponent implements OnInit {
  @Input() role: string;
  @Input() lane: string;
  @Input() totalDamageDealtToChampions: number = 0;
  
  constructor() { }

  ngOnInit() {
  }

}
