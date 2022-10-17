import { Component, OnDestroy, OnInit } from '@angular/core';
import { NbToastrService } from '@nebular/theme';
import { Observable, Subscription } from 'rxjs';
import { ISummonerMatch } from 'src/app/models/matches/summonerMatch';
import { ISummoner } from 'src/app/models/summoners/summoner';
import { ApiService } from 'src/app/services/api.service';
import { Endpoints } from 'src/app/utils/endpoints';

@Component({
  selector: 'app-summoners-matches',
  templateUrl: './summoners-matches.component.html',
  styleUrls: ['./summoners-matches.component.scss']
})
export class SummonersMatchesComponent implements OnInit, OnDestroy {
  public name: string = '';
  public matchesCount: number = 5;
  public matches$: Observable<ISummonerMatch[]>;
  
  private summonerSubscription: Subscription;

  constructor(
    private apiService: ApiService,
    private toastrService: NbToastrService) { }

  ngOnInit(): void {
  }

  ngOnDestroy(): void {
    if (this.summonerSubscription) {
      this.summonerSubscription.unsubscribe();
    }
  }

  getMatches(name: string): void {
    this.summonerSubscription = this.apiService.get<ISummoner>(`${Endpoints.Summoners}/${name}`).subscribe((summoner) => {
      if (!summoner) {
        this.showSummonerNotFound();
        return;
      }

      this.matches$ = this.apiService.get<ISummonerMatch[]>(`${Endpoints.Summoners}/${summoner.puuid}/matches?count=${this.matchesCount}`);
    }, (error) => {
      this.showSummonerNotFound();
    });
  }

  private showSummonerNotFound(): void {
    this.toastrService.danger('', 'Summoner not found.');
  }

}
