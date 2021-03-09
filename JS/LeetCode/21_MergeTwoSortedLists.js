
function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
     this.next = (next===undefined ? null : next)
 };


var mergeTwoLists = function(l1, l2) {
    
    var result = new ListNode()
    let dummy = result

    while(l1 != null || l2 != null){

        if(l1 == null){
            dummy.next = new ListNode(l2.val);
            l2 = l2.next;
        }
        else if(l2 == null){
            dummy.next = new ListNode(l1.val);
            l1 = l1.next;  
        }
        else if(l1.val <= l2.val){
            dummy.next = new ListNode(l1.val);
            l1 = l1.next;
        }else if(l1.val > l2.val){
            dummy.next = new ListNode(l2.val);
            l2 = l2.next;
        }

        dummy = dummy.next;
    }
    
   return result.next;
};

var l1 = new ListNode(1);
    l1.next = new ListNode(2);
    l1.next.next = new ListNode(4);

var l2 = new ListNode(1);
    l2.next = new ListNode(3);
    l2.next.next = new ListNode(4);

mergeTwoLists(l1, l2);
