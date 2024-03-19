using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStreamerBase
	/// </summary>
	/// <remarks>
	///    Superclass for filters that stream input pipeline
	///
	///
	/// This class can be used as a superclass for filters that want to
	/// stream their input pipeline by making multiple execution passes.
	/// The subclass needs to set NumberOfPasses to &gt; 1 before execution (
	/// usual in the constructor or in RequestInformation) to initiate
	/// streaming. vtkStreamerBase will handle streaming while calling
	/// ExecutePass() during each pass. CurrentIndex can be used to obtain
	/// the index for the current pass. Finally, PostExecute() is called
	/// after the last pass and can be used to cleanup any internal data
	/// structures and create the actual output.
	/// </remarks>
	// Token: 0x020008CA RID: 2250
	public abstract class vtkStreamerBase : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017416 RID: 95254 RVA: 0x0020A7A7 File Offset: 0x002089A7
		static vtkStreamerBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamerBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamerBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017417 RID: 95255 RVA: 0x0020A7CF File Offset: 0x002089CF
		public vtkStreamerBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017418 RID: 95256 RVA: 0x0020A7DD File Offset: 0x002089DD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017419 RID: 95257
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamerBase_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601741A RID: 95258 RVA: 0x0020A7E8 File Offset: 0x002089E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStreamerBase.vtkStreamerBase_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601741B RID: 95259
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamerBase_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601741C RID: 95260 RVA: 0x0020A808 File Offset: 0x00208A08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStreamerBase.vtkStreamerBase_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601741D RID: 95261
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamerBase_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601741E RID: 95262 RVA: 0x0020A824 File Offset: 0x00208A24
		public override int IsA(string type)
		{
			return vtkStreamerBase.vtkStreamerBase_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601741F RID: 95263
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamerBase_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017420 RID: 95264 RVA: 0x0020A844 File Offset: 0x00208A44
		public new static int IsTypeOf(string type)
		{
			return vtkStreamerBase.vtkStreamerBase_IsTypeOf_04(type);
		}

		// Token: 0x06017421 RID: 95265
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamerBase_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017422 RID: 95266 RVA: 0x0020A860 File Offset: 0x00208A60
		public new vtkStreamerBase NewInstance()
		{
			vtkStreamerBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamerBase.vtkStreamerBase_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamerBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017423 RID: 95267
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamerBase_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017424 RID: 95268 RVA: 0x0020A8BC File Offset: 0x00208ABC
		public new static vtkStreamerBase SafeDownCast(vtkObjectBase o)
		{
			vtkStreamerBase vtkStreamerBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamerBase.vtkStreamerBase_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamerBase = (vtkStreamerBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamerBase.Register(null);
				}
			}
			return vtkStreamerBase;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A07 RID: 6663
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamerBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A08 RID: 6664
		public new static readonly string MRClassNameKey = "class vtkStreamerBase";
	}
}
