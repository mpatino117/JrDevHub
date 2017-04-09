namespace jrDevHub.Controllers {

    export class MemberController {

        public members;

        constructor(private $memberService: jrDevHub.Services.MemberService) {
         this.GetMembers();   
        }

        public GetMembers() {
            this.$memberService.getMembers().then((res) => { this.members = res.data });
        }
    }
}