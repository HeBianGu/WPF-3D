using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationDataObjectMetaDataKey
	/// </summary>
	/// <remarks>
	///    key used to define meta-data of type vtkDataObject
	/// vtkInformationDataObjectMetaDataKey is a vtkInformationDataObjectKey
	/// that (shallow) copies itself downstream during the REQUEST_INFORMATION pass. Hence
	/// it can be used to provide meta-data of type vtkDataObject or any subclass.
	/// </remarks>
	// Token: 0x020009D9 RID: 2521
	public class vtkInformationDataObjectMetaDataKey : vtkInformationDataObjectKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A427 RID: 107559 RVA: 0x00246D84 File Offset: 0x00244F84
		static vtkInformationDataObjectMetaDataKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationDataObjectMetaDataKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationDataObjectMetaDataKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A428 RID: 107560 RVA: 0x00246DAC File Offset: 0x00244FAC
		public vtkInformationDataObjectMetaDataKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A429 RID: 107561 RVA: 0x00246DBA File Offset: 0x00244FBA
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A42A RID: 107562
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDataObjectMetaDataKey_CopyDefaultInformation_01(HandleRef pThis, HandleRef request, HandleRef fromInfo, HandleRef toInfo);

		/// <summary>
		/// Simply shallow copies the key from fromInfo to toInfo if request
		/// has the REQUEST_INFORMATION() key.
		/// This is used by the pipeline to propagate this key downstream.
		/// </summary>
		// Token: 0x0601A42B RID: 107563 RVA: 0x00246DC8 File Offset: 0x00244FC8
		public override void CopyDefaultInformation(vtkInformation request, vtkInformation fromInfo, vtkInformation toInfo)
		{
			vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_CopyDefaultInformation_01(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (fromInfo == null) ? default(HandleRef) : fromInfo.GetCppThis(), (toInfo == null) ? default(HandleRef) : toInfo.GetCppThis());
		}

		// Token: 0x0601A42C RID: 107564
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A42D RID: 107565 RVA: 0x00246E24 File Offset: 0x00245024
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A42E RID: 107566
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A42F RID: 107567 RVA: 0x00246E44 File Offset: 0x00245044
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A430 RID: 107568
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDataObjectMetaDataKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A431 RID: 107569 RVA: 0x00246E60 File Offset: 0x00245060
		public override int IsA(string type)
		{
			return vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A432 RID: 107570
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDataObjectMetaDataKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A433 RID: 107571 RVA: 0x00246E80 File Offset: 0x00245080
		public new static int IsTypeOf(string type)
		{
			return vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_IsTypeOf_05(type);
		}

		// Token: 0x0601A434 RID: 107572
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDataObjectMetaDataKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationDataObjectMetaDataKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601A435 RID: 107573 RVA: 0x00246E9C File Offset: 0x0024509C
		public new static vtkInformationDataObjectMetaDataKey MakeKey(string name, string location)
		{
			vtkInformationDataObjectMetaDataKey vtkInformationDataObjectMetaDataKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectMetaDataKey = (vtkInformationDataObjectMetaDataKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectMetaDataKey.Register(null);
				}
			}
			return vtkInformationDataObjectMetaDataKey;
		}

		// Token: 0x0601A436 RID: 107574
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDataObjectMetaDataKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A437 RID: 107575 RVA: 0x00246F08 File Offset: 0x00245108
		public new vtkInformationDataObjectMetaDataKey NewInstance()
		{
			vtkInformationDataObjectMetaDataKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationDataObjectMetaDataKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A438 RID: 107576
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDataObjectMetaDataKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A439 RID: 107577 RVA: 0x00246F64 File Offset: 0x00245164
		public new static vtkInformationDataObjectMetaDataKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationDataObjectMetaDataKey vtkInformationDataObjectMetaDataKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDataObjectMetaDataKey.vtkInformationDataObjectMetaDataKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectMetaDataKey = (vtkInformationDataObjectMetaDataKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectMetaDataKey.Register(null);
				}
			}
			return vtkInformationDataObjectMetaDataKey;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C82 RID: 7298
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationDataObjectMetaDataKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C83 RID: 7299
		public new static readonly string MRClassNameKey = "class vtkInformationDataObjectMetaDataKey";
	}
}
