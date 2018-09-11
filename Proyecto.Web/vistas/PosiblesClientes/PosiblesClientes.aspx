<%@ Page Title="" Language="C#" MasterPageFile="~/Resource/Templete/Temple.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.vistas.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="ContentHeder" ContentPlaceHolderID="header" runat="server">   </asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
      <div class="mx-auto mt-5">
        <%---primera secion----%>
         <div class="form-group">
         <div class="form-row">
                <div class="col-md-12">
                    <h3>
                        <b> Posibles clientes</b>
                <asp:Label ID="LblOpcion" runat="server" ></asp:Label>
                        </h3>
             </div>
           <//div>
         </div>

     <div class="form-group">
         <div class="form-row">
             <div class="col-md-3">
    <asp:Label ID="lblidentificacion" runat="server" Text="identificacion"></asp:Label>
    <asp:TextBox ID="txtidentificacion" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
              <div class="col-md-3">
                       
                        <asp:Label ID="Lblempresa" runat="server" Text="Empresa"></asp:Label>
                        <asp:TextBox ID="txtEmpresa" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
              <div class="col-md-3">
                         <asp:Label ID="LblPrimerNombre" runat="server" Text="PrimerNombre"></asp:Label>
                        <asp:TextBox ID="txtPrimerNombre" runat="server" CssClass="form-control"></asp:TextBox>

             </div>
              <div class="col-md-3">
                        <asp:Label ID="LblSegundoNombre" runat="server" Text="SegundoNombre"></asp:Label>
                        <asp:TextBox ID="txtSegundoNombre" runat="server" CssClass="form-control"></asp:TextBox>
             </div>

             <//div>
         </div>

        <%---segunda secion----%>
         <div class="form-group">
         <div class="form-row">
             <div class="col-md-3">
    <asp:Label ID="LblPrimerApellido" runat="server" Text="PrimerApellido"></asp:Label>
    <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
              <div class="col-md-3">
                       
                        <asp:Label ID="LblSegundoApellido" runat="server" Text="SegundoApellido"></asp:Label>
                        <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
              <div class="col-md-3">
                         <asp:Label ID="LblDireccion" runat="server" Text="Direccion"></asp:Label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>

             </div>
              <div class="col-md-3">
                        <asp:Label ID="LblTelefono" runat="server" Text="Telefono"></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
             </div>

             <//div>
         </div>
         <%---tercera secion----%>
         <div class="form-group">
         <div class="form-row">
                <div class="col-md-12">
                       
                        <asp:Label ID="LblCorreo" runat="server" Text="Correo"></asp:Label>
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             
             <//div>
         </div>
        <%---cuarta secion----%>
         <div class="form-group">
         <div class="form-row">
                <div class="col-md-12">
                     
                     <asp:Button  runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btn_Guardar" ></asp:Button>
                    <asp:Button  runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick=  "btnCancelar_Click" ></asp:Button>
             </div>
           <//div>
         </div>
         <%---quinta secion----%>
         <div class="form-group">
         <div class="form-row">
                <div class="col-md-12">
                  
                    <h3>
                        <b>Resultado</b>
               
                        </h3>
             </div>
           <//div>
         </div>
         <div class="form-group">
         <div class="form-row">
                <div class="col-md-12" style="overflow:auto">
                   
                    <asp:GridView runat="server"
                        ID="gvwDatos" 
                        width="100%"
                        AutoGenerateColumns="False"
                        EmptyDataText="No se encontraron registros" 
                        BackColor="White" 
                        BorderColor="#3366CC"
                        BorderStyle="None" 
                        BorderWidth="1px" CellPadding="4"
                        OnRowCommand="gvwDatos_RowCommand"
                        >

                        

                        <Columns>
                           <%---Representacion de datos WEB----%>
                            <asp:TemplateField HeaderText="Identificacion">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblIdentificacion" Text='<%# Bind("clieidentificacion")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%---Representacion en CELDAS----%>
                            <asp:BoundField   HeaderText="Empresa" DataField="clieEmpresa" />
                            <asp:BoundField   HeaderText="Primer Nombre" DataField="cliePrimerNombre" />
                            <asp:BoundField   HeaderText="Segundo Nombre" DataField="clieSegundoNombre" />
                            <asp:BoundField   HeaderText="Primer Apellido" DataField="cliePrimerApellido" />
                            <asp:BoundField   HeaderText="Segundo Nombre" DataField="clieSegundoApellido" />
                            <asp:BoundField   HeaderText="Direccion" DataField="cleDireccion" />
                             <asp:BoundField   HeaderText="Telefono" DataField="clieTelefono" />
                             <asp:BoundField   HeaderText="Correo" DataField="clieCorreo" />
                            
                        </Columns>

                        <Columns>
                           <%---------------EDITAR----------------%>
                            <asp:TemplateField HeaderText="Editar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="lblEditar"  runat="server" ImageUrl="~/Resource/Imagenes/removeree.jpg"  
                                 CommandName="Editar" CommandArgument="<%#((GridViewRow)Container).RowIndex %>" Width="20px" Height="20px" />
                                </ItemTemplate>
                                 <itemStyle HorizontalAlign="center" />
                               </asp:TemplateField>


                            <%---------------Elininar----------------%>
                            <asp:TemplateField HeaderText="Eliminarr">
                                <ItemTemplate>
                                    <asp:ImageButton ID="lblEliminar"  runat="server" ImageUrl="~/Resource/Imagenes/eliminar.png"
                                 CommandName="Eliminar" CommandArgument="<%#((GridViewRow)Container).RowIndex %>" Width="20px" Height="20px"/>
                                </ItemTemplate>
                                 <itemStyle HorizontalAlign="center" />
                               </asp:TemplateField>
                           
                                   </Columns>



                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                        </asp:GridView>
                    
             </div>
           <//div>
         </div>
         </div>
</asp:Content>
