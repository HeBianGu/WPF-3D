using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCPExodusIIElementBlock
	/// </summary>
	/// <remarks>
	///    Uses an Exodus II element block as a
	///  vtkMappedUnstructuredGrid's implementation.
	///
	///
	/// This class allows raw data arrays returned by the Exodus II library to be
	/// used directly in VTK without repacking the data into the vtkUnstructuredGrid
	/// memory layout. Use the vtkCPExodusIIInSituReader to read an Exodus II file's
	/// data into this structure.
	/// </remarks>
	// Token: 0x020001B5 RID: 437
	public class vtkCPExodusIIElementBlock : vtkUnstructuredGridBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005418 RID: 21528 RVA: 0x0007A6FB File Offset: 0x000788FB
		static vtkCPExodusIIElementBlock()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCPExodusIIElementBlock.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCPExodusIIElementBlock"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005419 RID: 21529 RVA: 0x0007A723 File Offset: 0x00078923
		public vtkCPExodusIIElementBlock(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600541A RID: 21530
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIElementBlock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600541B RID: 21531 RVA: 0x0007A734 File Offset: 0x00078934
		public new static vtkCPExodusIIElementBlock New()
		{
			vtkCPExodusIIElementBlock result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCPExodusIIElementBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600541C RID: 21532 RVA: 0x0007A788 File Offset: 0x00078988
		public vtkCPExodusIIElementBlock() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600541D RID: 21533 RVA: 0x0007A7CC File Offset: 0x000789CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600541E RID: 21534
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600541F RID: 21535 RVA: 0x0007A7D8 File Offset: 0x000789D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005420 RID: 21536
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005421 RID: 21537 RVA: 0x0007A7F8 File Offset: 0x000789F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005422 RID: 21538
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCPExodusIIElementBlock_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005423 RID: 21539 RVA: 0x0007A814 File Offset: 0x00078A14
		public override int IsA(string type)
		{
			return vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06005424 RID: 21540
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCPExodusIIElementBlock_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005425 RID: 21541 RVA: 0x0007A834 File Offset: 0x00078A34
		public new static int IsTypeOf(string type)
		{
			return vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_IsTypeOf_04(type);
		}

		// Token: 0x06005426 RID: 21542
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIElementBlock_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005427 RID: 21543 RVA: 0x0007A850 File Offset: 0x00078A50
		public new vtkCPExodusIIElementBlock NewInstance()
		{
			vtkCPExodusIIElementBlock result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCPExodusIIElementBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005428 RID: 21544
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIElementBlock_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005429 RID: 21545 RVA: 0x0007A8AC File Offset: 0x00078AAC
		public new static vtkCPExodusIIElementBlock SafeDownCast(vtkObjectBase o)
		{
			vtkCPExodusIIElementBlock vtkCPExodusIIElementBlock = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCPExodusIIElementBlock.vtkCPExodusIIElementBlock_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCPExodusIIElementBlock = (vtkCPExodusIIElementBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCPExodusIIElementBlock.Register(null);
				}
			}
			return vtkCPExodusIIElementBlock;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007D7 RID: 2007
		public new const string MRFullTypeName = "Kitware.VTK.vtkCPExodusIIElementBlock";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007D8 RID: 2008
		public new static readonly string MRClassNameKey = "class vtkCPExodusIIElementBlock";
	}
}
