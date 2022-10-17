import { ISummonerChampion } from "../champions/summonerChampion";
import { ITeam } from "./team";

export interface ISummonerMatch {
    name: string;
    win: boolean;
    duration: number;
    date: string;

    kills: number;
    assists: number;
    deaths: number;

    role: string;
    lane: string;
    totalDamageDealtToChampions: number;

    champion: ISummonerChampion;
    teams: ITeam[];
}
