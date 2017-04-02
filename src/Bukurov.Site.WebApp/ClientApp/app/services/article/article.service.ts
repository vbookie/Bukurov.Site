import { Http } from '@angular/http';
import { ArticleViewModel } from './article-view-models';

export class ArticleService {
    private http: Http;

    constructor(http: Http) {
        this.http = http;
    }

    getArticles() : ArticleViewModel[] {
        this.http.get('/api/articles').subscribe(result => {
            var articles = result.json() as ArticleViewModel[];
            return articles;
        });
    }
}