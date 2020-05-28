﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DataEntryDashboard.master" AutoEventWireup="true" CodeFile="DataEntryFinalStep.aspx.cs" Inherits="DataEntryFinalStep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Final Step</title>
<script type="text/javascript">
    function ShowHideDiv() {
        var chkYes = document.getElementById("chkYes");
        var chkNo = document.getElementById("chkNo");
        var dvdelivered = document.getElementById("pnldelivered");
        dvdelivered.style.display = chkYes.checked ? "block" : "none";

        var dvdelivered = document.getElementById("pnlreturned");
        dvdelivered.style.display = chkNo.checked ? "block" : "none";
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">   
    
    
     <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">New Final Step Form</h5>
                                            <p class="m-b-0">Data will be add by data entry operator only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="#"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="#">New Final Step</a>
                                            </li>
                                             <li class="breadcrumb-item"><a href="#">Form</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Page-header end -->
                    


                        <div class="pcoded-inner-content">
                            <div class="main-body">
                                <div class="page-wrapper">
                                    <!-- Page body start -->
                                    <div class="page-body">
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <!-- Basic Inputs Validation start -->
                                                <div class="card">
                                                    <div class="card-header">
                                                        <h5>New Final Step</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">

                                                            <div class="form-group row">
                                                                   <div class="col-md-4 col-lg-2">
                                                                       <label for="userName-1" class="block">Select Shipment</label>
                                                                   </div>
                                                                   <div class="col-md-8 col-lg-10">
                                                                       <asp:DropDownList ID="ddlshipment" runat="server" class="form-control form-control-primary"></asp:DropDownList>
                                                                           
                                                                   </div>
                                                               </div>

                                                               <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block" id="a" runat="server">Final Status</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10 form-radio m-b-30">
                                                                                        
                                                         
                                                                                          
                                                                                 <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-success radio-inline">
                                                                                    <label>
                                                                                        <input type="radio" id="chkYes" name="chkPassPort" onclick="ShowHideDiv()" value="delivered" />
    Yes
                                                                                        <i class="helper"></i>Delivered
                                                                                    </label>
                                                                                </div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-danger radio-inline">
                                                                                    <label>
                                                                                       <input type="radio" id="chkNo" name="chkPassPort" onclick="ShowHideDiv()" value="returned" />
    No
                                                                                        <i class="helper"></i>Returned
                                                                                    </label>
                                                                                </div>
                                                                                
                                                                                <span class="messages"></span>
                                                                        
                                                                                        
                                                                                            
                                                                                    </div>
                                                                                </div>

                                                            

                                                           
                                                            
                                                            <div id="pnldelivered" style="display: none">
                                                                    <div class="form-group row">
                                                                <div class="col-md-4 col-lg-2">
                                                                    <label for="phone-2" class="block">Delivered On</label>
                                                                </div>
                                                                <div class="col-md-8 col-lg-10">
                                                                    <input id="txtdelivered" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
                                                                </div>
                                                            </div>
                                                            </div>
                                                            
                                                            
                                                            
                                                            
                                                            
                                                            


                                                          <div id="pnlreturned" style="display: none">

                                                                <div class="form-group row">
                                                                <div class="col-md-4 col-lg-2">
                                                                    <label for="phone-2" class="block">Returned On</label>
                                                                </div>
                                                                <div class="col-md-8 col-lg-10">
                                                                    <input id="txtreturned" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
                                                                </div>
                                                            </div>


                                                               <div class="form-group row">
                                                                   <div class="col-md-4 col-lg-2">
                                                                       <label for="userName-1" class="block">Select Reason</label>
                                                                   </div>
                                                                   <div class="col-md-8 col-lg-10">
                                                                       <asp:DropDownList ID="ddlreason" runat="server" class="form-control form-control-primary"></asp:DropDownList>
                                                                           
                                                                   </div>
                                                               </div>

                                                                 <div class="form-group row">
                                                                  <div class="col-md-4 col-lg-2">
                                                                        <label for="userName-1" class="block">Discription</label>
                                                                  </div>
                                                                  <div class="col-md-8 col-lg-10">
                                                                        <textarea id="txtdescription" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="255" rows="4" placeholder="Type your Discription here (Only 255 words here)"></textarea>
                                                                                      
                                                                  </div>
                                                              </div>

                                                            </div>



                                                            <div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="btn btn-primary m-b-0" OnClick="btnsubmit_Click" />
                                                                </div>
                                                            </div>
                                                        </form>
                                                    </div>
                                                </div>
                                                <!-- Basic Inputs Validation end -->
                                               
                                        </div>
                                    </div>
                                </div>
                                <!-- Page body end -->
                            </div>
                        </div>
                    </div>
     </div>
</asp:Content>

