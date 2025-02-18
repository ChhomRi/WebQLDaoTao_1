<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QLMonHoc.aspx.cs" Inherits="WebQLDaoTao_1.QLMonHoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
     <div class="jumbotron" style="margin-top:20px">
       <h3>Thiết kế nội dung trang quản lý môn học</h3>
    </div>
    <div>
        <button type="button" class="btn btn-infog" data-toggle="modal" data-target="#myModal">Thêm môn học mới </button>
        <div id="myModal" class="modal fade " role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Thêm môn học mới</h4>

                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <label>Mã môn</label>
                            <asp:TextBox ID="txtMaKH" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Tên môn</label>
                            <asp:TextBox ID="txtTenMH" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Số tiết</label>
                            <asp:TextBox ID="txtSoTet" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btThem" runat="server" Text="Thêm" OnClick="btThem_Click" CssClass="btn btn-success"></asp:Button>
                        </div>
                    </div>
                    <div class="form-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>

        </div>
    </div >
     <div style="background-color: #FF9999">
        <asp:GridView ID="gvMonHoc" runat="server" DataKeyNames="MaMH" 
            AutoGenerateColumns="False" CssClass="table table-bordered table-hover" OnRowEditing="gvMonHoc_RowEditing" OnRowCancelingEdit="gvMonHoc_RowCancelingEdit" OnRowUpdating="gvMonHoc_RowUpdating" BackColor="Red" OnRowDeleting="gvMonHoc_RowDeleting">
            <Columns>
                <asp:BoundField HeaderText="Mã môn học" DataField="MaMH" ReadOnly="true" />
                <asp:BoundField HeaderText="Tên môn học" DataField="TenMH" />
                <asp:BoundField HeaderText="Số tiết" DataField="SoTiet" />
                <asp:CommandField HeaderText="Chọn tác vụ" ShowEditButton="true" ShowDeleteButton="true" ButtonType="Button" EditText="Sửa" DeleteText="Xoá" />
            </Columns>
            <HeaderStyle BackColor="#0066cc" ForeColor="#ffffff"/>
        </asp:GridView>
    </div>
</asp:Content>
