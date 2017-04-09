namespace jrDevHub.Services{
    
    export class MemberService {
        public resource = "/api/members";
        constructor(private $http: ng.IHttpService) {
            
        }

        //get all members to view
        public getMembers() {
            return this.$http.get(this.resource);
        }

        //get member by id
        public getMember(id) {
            return this.$http.get(this.resource + id);
        }
    }
    angular.module("jrDevHub").service("$memberService", MemberService);
}