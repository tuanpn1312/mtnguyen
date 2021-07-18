using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class Nhankhau
    {
     
    }
}


class NodeNhankhau //Một Node
{
    public int data;
    public NodeNhankhau next;
}; 
//——————————————-
class ListNhankhau //Class Danh sách liên kết
{
    NodeNhankhau pHead, pTail; //Headnode nắm giữ đầu và cuối trang danh sách
    public CreateNode() //Khởi tạo
    {
        headnode = new ListNode();
        headnode.data = 0;
        tailnode = new ListNode();
        tailnode.data = 0;
        headnode.next = tailnode;
        tailnode.next = tailnode;
    }
    public ListNode move_to_node(int k) //Hàm di chuyển đến Node có vị trí k
    {
        int i;
        ListNode temp = headnode;
        for (i = 0; i < k && temp != tailnode; i++)
        {
            temp = temp.next;
        }
        return temp;
    }
    public void insert_node(ListNode a_node, int position) //Chèn một Node vào vị trí Position
    {
        a_node.next = move_to_node(position).next;
        move_to_node(position).next = a_node;
    }
    public void delete_node(int position) //Xóa một Node tại vị trí position
    {
        ListNode temp;
        temp = move_to_node(position);
        move_to_node(position – 1).next = move_to_node(position + 1);
    }
    public int list_length() // Lấy số Node trong danh sách
    {
        int i;
        ListNode temp = headnode;
        for (i = 0; temp != tailnode; i++)
        {
            temp = temp.next;
        }
        return i – 1;
    }
    int search(int k, int n) //Tìm Node
    {
        ListNode temp = headnode;
        temp = headnode.next;
        for (; temp.data != k && temp != tailnode; temp = temp.next) ;
        if (temp == tailnode)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
    public void show_list() //Xuất tất cả các Node
    {
        ListNode temp = headnode;
        temp = headnode.next;
        for (; temp != tailnode; temp = temp.next)
            Console.WriteLine(temp.data);
    }
};