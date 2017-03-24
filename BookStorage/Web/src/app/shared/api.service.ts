import {Http, RequestOptions, Headers} from '@angular/http';
import {Response} from "@angular/http";
import {Observable} from "rxjs";
import {Injectable} from "@angular/core";
import {CustomConfig} from "../custom.config";
import {ConfigService} from "ng2-config";

@Injectable()
export class ApiService {
    private apiRoutes = {
        dev: "http://localhost:5000/api/",
        master: "/api/"
    };
    private baseApiUrl: any;

    constructor(private http: Http, private config: ConfigService) {
        console.log("config: ", this.config.getSettings('apiUrl', 'dev'));
        this.baseApiUrl = this.config.getSettings('apiUrl', 'dev');
    }

    public getAll(url: string): Observable<Response> {
        console.log("yyy: ", this.baseApiUrl);
        return this.http.get(this.baseApiUrl + url);
    }

    public getById(url: string, id: number): Observable<Response> {
        return this.http.get(this.baseApiUrl + url + '/' + id);
    }

    public delete(url: string, id: number): Observable<Response> {
        return this.http.delete(this.baseApiUrl + url + '/' + id);
    }

    public add(url: string, data): Observable<Response> {
        let body = JSON.stringify(data);
        return this.http.post(this.baseApiUrl + url, body, this.getOptions());
    }

    public update(url: string, id: number, data): Observable<Response> {
        let body = JSON.stringify(data);
        return this.http.put(this.baseApiUrl + url + "/" + id, body, this.getOptions());
    }

    private getOptions(): RequestOptions {
        let opts: RequestOptions = new RequestOptions();
        opts.headers = new Headers();
        opts.headers.append("Content-Type", "application/json");
        return opts;
    }
};
