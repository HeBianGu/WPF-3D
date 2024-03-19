using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPOpenFOAMReader
	/// </summary>
	/// <remarks>
	///    reads a decomposed dataset in OpenFOAM format
	///
	/// vtkPOpenFOAMReader creates a multiblock dataset. It reads
	/// parallel-decomposed mesh information and time dependent data.  The
	/// polyMesh folders contain mesh information. The time folders contain
	/// transient data for the cells. Each folder can contain any number of
	/// data files.
	///
	/// @par Thanks:
	/// This class was developed by Takuya Oshima at Niigata University,
	/// Japan (oshima@eng.niigata-u.ac.jp).
	/// </remarks>
	// Token: 0x02000163 RID: 355
	public class vtkPOpenFOAMReader : vtkOpenFOAMReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060043E8 RID: 17384 RVA: 0x00063313 File Offset: 0x00061513
		static vtkPOpenFOAMReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOpenFOAMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOpenFOAMReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060043E9 RID: 17385 RVA: 0x0006333B File Offset: 0x0006153B
		public vtkPOpenFOAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060043EA RID: 17386
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOpenFOAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043EB RID: 17387 RVA: 0x0006334C File Offset: 0x0006154C
		public new static vtkPOpenFOAMReader New()
		{
			vtkPOpenFOAMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043EC RID: 17388 RVA: 0x000633A0 File Offset: 0x000615A0
		public vtkPOpenFOAMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPOpenFOAMReader.vtkPOpenFOAMReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060043ED RID: 17389 RVA: 0x000633E4 File Offset: 0x000615E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060043EE RID: 17390
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPOpenFOAMReader.caseType vtkPOpenFOAMReader_GetCaseType_01(HandleRef pThis);

		/// <summary>
		/// Set and get case type. 0 = decomposed case, 1 = reconstructed case.
		/// </summary>
		// Token: 0x060043EF RID: 17391 RVA: 0x000633F0 File Offset: 0x000615F0
		public virtual vtkPOpenFOAMReader.caseType GetCaseType()
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_GetCaseType_01(base.GetCppThis());
		}

		// Token: 0x060043F0 RID: 17392
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOpenFOAMReader_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x060043F1 RID: 17393 RVA: 0x00063410 File Offset: 0x00061610
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_GetController_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x060043F2 RID: 17394
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOpenFOAMReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043F3 RID: 17395 RVA: 0x00063480 File Offset: 0x00061680
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060043F4 RID: 17396
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOpenFOAMReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043F5 RID: 17397 RVA: 0x000634A0 File Offset: 0x000616A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060043F6 RID: 17398
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOpenFOAMReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043F7 RID: 17399 RVA: 0x000634BC File Offset: 0x000616BC
		public override int IsA(string type)
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060043F8 RID: 17400
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOpenFOAMReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043F9 RID: 17401 RVA: 0x000634DC File Offset: 0x000616DC
		public new static int IsTypeOf(string type)
		{
			return vtkPOpenFOAMReader.vtkPOpenFOAMReader_IsTypeOf_06(type);
		}

		// Token: 0x060043FA RID: 17402
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOpenFOAMReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043FB RID: 17403 RVA: 0x000634F8 File Offset: 0x000616F8
		public new vtkPOpenFOAMReader NewInstance()
		{
			vtkPOpenFOAMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060043FC RID: 17404
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOpenFOAMReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043FD RID: 17405 RVA: 0x00063554 File Offset: 0x00061754
		public new static vtkPOpenFOAMReader SafeDownCast(vtkObjectBase o)
		{
			vtkPOpenFOAMReader vtkPOpenFOAMReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOpenFOAMReader.vtkPOpenFOAMReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOpenFOAMReader = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOpenFOAMReader.Register(null);
				}
			}
			return vtkPOpenFOAMReader;
		}

		// Token: 0x060043FE RID: 17406
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOpenFOAMReader_SetCaseType_10(HandleRef pThis, int t);

		/// <summary>
		/// Set and get case type. 0 = decomposed case, 1 = reconstructed case.
		/// </summary>
		// Token: 0x060043FF RID: 17407 RVA: 0x000635D3 File Offset: 0x000617D3
		public void SetCaseType(int t)
		{
			vtkPOpenFOAMReader.vtkPOpenFOAMReader_SetCaseType_10(base.GetCppThis(), t);
		}

		// Token: 0x06004400 RID: 17408
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOpenFOAMReader_SetController_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x06004401 RID: 17409 RVA: 0x000635E4 File Offset: 0x000617E4
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPOpenFOAMReader.vtkPOpenFOAMReader_SetController_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400070C RID: 1804
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOpenFOAMReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400070D RID: 1805
		public new static readonly string MRClassNameKey = "class vtkPOpenFOAMReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000164 RID: 356
		public enum caseType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400070F RID: 1807
			DECOMPOSED_CASE,
			/// <summary>enum member</summary>
			// Token: 0x04000710 RID: 1808
			RECONSTRUCTED_CASE
		}
	}
}
