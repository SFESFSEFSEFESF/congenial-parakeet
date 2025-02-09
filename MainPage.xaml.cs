<? xml version = "1.0" encoding = "utf-8" ?>
< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
             x: Class = "OtpApp.MainPage"
             BackgroundColor = "White" >

    < StackLayout Padding = "20" >
        < !--Phone Number Entry -->
        <Entry x:Name = "PhoneNumberEntry"
               Placeholder = "Enter your phone number"
               Keyboard = "Telephone"
               HorizontalOptions = "FillAndExpand" />

        < !--Send OTP Button -->
        <Button Text="Send OTP" 
                Clicked="OnSendOtpClicked"
                BackgroundColor="#007AFF"
                TextColor="White"/>

        <!-- OTP Entry -->
        <Entry x:Name = "OtpEntry"
               Placeholder = "Enter OTP"
               Keyboard = "Numeric"
               HorizontalOptions = "FillAndExpand" />

        < !--Verify OTP Button -->
        <Button Text="Verify OTP" 
                Clicked="OnVerifyOtpClicked"
                BackgroundColor="#34C759"
                TextColor="White"/>
    </StackLayout>
</ContentPage>
