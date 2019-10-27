// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  union OperationResult switch (OperationResultCode code)
//  {
//  case opINNER:
//      union switch (OperationType type)
//      {
//      case CREATE_ACCOUNT:
//          CreateAccountResult createAccountResult;
//      case PAYMENT:
//          PaymentResult paymentResult;
//      case PATH_PAYMENT_STRICT_RECEIVE:
//          PathPaymentStrictReceiveResult pathPaymentStrictReceiveResult;
//      case MANAGE_SELL_OFFER:
//          ManageSellOfferResult manageSellOfferResult;
//      case CREATE_PASSIVE_SELL_OFFER:
//          ManageSellOfferResult createPassiveSellOfferResult;
//      case SET_OPTIONS:
//          SetOptionsResult setOptionsResult;
//      case CHANGE_TRUST:
//          ChangeTrustResult changeTrustResult;
//      case ALLOW_TRUST:
//          AllowTrustResult allowTrustResult;
//      case ACCOUNT_MERGE:
//          AccountMergeResult accountMergeResult;
//      case INFLATION:
//          InflationResult inflationResult;
//      case MANAGE_DATA:
//          ManageDataResult manageDataResult;
//      case BUMP_SEQUENCE:
//          BumpSequenceResult bumpSeqResult;
//      case MANAGE_BUY_OFFER:
//  	ManageBuyOfferResult manageBuyOfferResult;
//      case PATH_PAYMENT_STRICT_SEND:
//          PathPaymentStrictSendResult pathPaymentStrictSendResult;
//      }
//      tr;
//  default:
//      void;
//  };
//  ===========================================================================
    public class OperationResult
    {
        public OperationResult()
        {
        }

        public OperationResultCode Discriminant { get; set; } = new OperationResultCode();
        public OperationResultTr Tr { get; set; }

        public static void Encode(XdrDataOutputStream stream, OperationResult encodedOperationResult)
        {
            stream.WriteInt((int) encodedOperationResult.Discriminant.InnerValue);
            switch (encodedOperationResult.Discriminant.InnerValue)
            {
                case OperationResultCode.OperationResultCodeEnum.opINNER:
                    OperationResultTr.Encode(stream, encodedOperationResult.Tr);
                    break;
                default:
                    break;
            }
        }

        public static OperationResult Decode(XdrDataInputStream stream)
        {
            OperationResult decodedOperationResult = new OperationResult();
            OperationResultCode discriminant = OperationResultCode.Decode(stream);
            decodedOperationResult.Discriminant = discriminant;
            switch (decodedOperationResult.Discriminant.InnerValue)
            {
                case OperationResultCode.OperationResultCodeEnum.opINNER:
                    decodedOperationResult.Tr = OperationResultTr.Decode(stream);
                    break;
                default:
                    break;
            }

            return decodedOperationResult;
        }

        public class OperationResultTr
        {
            public OperationResultTr()
            {
            }

            public OperationType Discriminant { get; set; } = new OperationType();
            public CreateAccountResult CreateAccountResult { get; set; }
            public PaymentResult PaymentResult { get; set; }
            public PathPaymentStrictReceiveResult PathPaymentStrictReceiveResult { get; set; }
            public ManageSellOfferResult ManageSellOfferResult { get; set; }
            public ManageSellOfferResult CreatePassiveSellOfferResult { get; set; }
            public SetOptionsResult SetOptionsResult { get; set; }
            public ChangeTrustResult ChangeTrustResult { get; set; }
            public AllowTrustResult AllowTrustResult { get; set; }
            public AccountMergeResult AccountMergeResult { get; set; }
            public InflationResult InflationResult { get; set; }
            public ManageDataResult ManageDataResult { get; set; }
            public BumpSequenceResult BumpSeqResult { get; set; }
            public ManageBuyOfferResult ManageBuyOfferResult { get; set; }
            public PathPaymentStrictSendResult PathPaymentStrictSendResult { get; set; }

            public static void Encode(XdrDataOutputStream stream, OperationResultTr encodedOperationResultTr)
            {
                stream.WriteInt((int) encodedOperationResultTr.Discriminant.InnerValue);
                switch (encodedOperationResultTr.Discriminant.InnerValue)
                {
                    case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
                        CreateAccountResult.Encode(stream, encodedOperationResultTr.CreateAccountResult);
                        break;
                    case OperationType.OperationTypeEnum.PAYMENT:
                        PaymentResult.Encode(stream, encodedOperationResultTr.PaymentResult);
                        break;
                    case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_RECEIVE:
                        PathPaymentStrictReceiveResult.Encode(stream,
                            encodedOperationResultTr.PathPaymentStrictReceiveResult);
                        break;
                    case OperationType.OperationTypeEnum.MANAGE_SELL_OFFER:
                        ManageSellOfferResult.Encode(stream, encodedOperationResultTr.ManageSellOfferResult);
                        break;
                    case OperationType.OperationTypeEnum.CREATE_PASSIVE_SELL_OFFER:
                        ManageSellOfferResult.Encode(stream, encodedOperationResultTr.CreatePassiveSellOfferResult);
                        break;
                    case OperationType.OperationTypeEnum.SET_OPTIONS:
                        SetOptionsResult.Encode(stream, encodedOperationResultTr.SetOptionsResult);
                        break;
                    case OperationType.OperationTypeEnum.CHANGE_TRUST:
                        ChangeTrustResult.Encode(stream, encodedOperationResultTr.ChangeTrustResult);
                        break;
                    case OperationType.OperationTypeEnum.ALLOW_TRUST:
                        AllowTrustResult.Encode(stream, encodedOperationResultTr.AllowTrustResult);
                        break;
                    case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
                        AccountMergeResult.Encode(stream, encodedOperationResultTr.AccountMergeResult);
                        break;
                    case OperationType.OperationTypeEnum.INFLATION:
                        InflationResult.Encode(stream, encodedOperationResultTr.InflationResult);
                        break;
                    case OperationType.OperationTypeEnum.MANAGE_DATA:
                        ManageDataResult.Encode(stream, encodedOperationResultTr.ManageDataResult);
                        break;
                    case OperationType.OperationTypeEnum.BUMP_SEQUENCE:
                        BumpSequenceResult.Encode(stream, encodedOperationResultTr.BumpSeqResult);
                        break;
                    case OperationType.OperationTypeEnum.MANAGE_BUY_OFFER:
                        ManageBuyOfferResult.Encode(stream, encodedOperationResultTr.ManageBuyOfferResult);
                        break;
                    case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_SEND:
                        PathPaymentStrictSendResult.Encode(stream,
                            encodedOperationResultTr.PathPaymentStrictSendResult);
                        break;
                }
            }

            public static OperationResultTr Decode(XdrDataInputStream stream)
            {
                OperationResultTr decodedOperationResultTr = new OperationResultTr();
                OperationType discriminant = OperationType.Decode(stream);
                decodedOperationResultTr.Discriminant = discriminant;
                switch (decodedOperationResultTr.Discriminant.InnerValue)
                {
                    case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
                        decodedOperationResultTr.CreateAccountResult = CreateAccountResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.PAYMENT:
                        decodedOperationResultTr.PaymentResult = PaymentResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_RECEIVE:
                        decodedOperationResultTr.PathPaymentStrictReceiveResult =
                            PathPaymentStrictReceiveResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.MANAGE_SELL_OFFER:
                        decodedOperationResultTr.ManageSellOfferResult = ManageSellOfferResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.CREATE_PASSIVE_SELL_OFFER:
                        decodedOperationResultTr.CreatePassiveSellOfferResult = ManageSellOfferResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.SET_OPTIONS:
                        decodedOperationResultTr.SetOptionsResult = SetOptionsResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.CHANGE_TRUST:
                        decodedOperationResultTr.ChangeTrustResult = ChangeTrustResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.ALLOW_TRUST:
                        decodedOperationResultTr.AllowTrustResult = AllowTrustResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
                        decodedOperationResultTr.AccountMergeResult = AccountMergeResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.INFLATION:
                        decodedOperationResultTr.InflationResult = InflationResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.MANAGE_DATA:
                        decodedOperationResultTr.ManageDataResult = ManageDataResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.BUMP_SEQUENCE:
                        decodedOperationResultTr.BumpSeqResult = BumpSequenceResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.MANAGE_BUY_OFFER:
                        decodedOperationResultTr.ManageBuyOfferResult = ManageBuyOfferResult.Decode(stream);
                        break;
                    case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_SEND:
                        decodedOperationResultTr.PathPaymentStrictSendResult =
                            PathPaymentStrictSendResult.Decode(stream);
                        break;
                }

                return decodedOperationResultTr;
            }
        }
    }
}