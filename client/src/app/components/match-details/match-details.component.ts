import { Component, Input, OnInit } from '@angular/core';
import { ISummonerMatch } from 'src/app/models/matches/summonerMatch';

@Component({
  selector: 'app-match-details',
  templateUrl: './match-details.component.html',
  styleUrls: ['./match-details.component.scss']
})
export class MatchDetailsComponent implements OnInit {
  @Input() match: ISummonerMatch;
  
  constructor() { }

  ngOnInit() {
  }

}
