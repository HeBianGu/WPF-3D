using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNonOverlappingAMR
	/// </summary>
	/// <remarks>
	///    A concrete instance of vtkUniformGridAMR to store uniform grids at different
	///  levels of resolution that do not overlap with each other.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUniformGridAMR
	/// </seealso>
	// Token: 0x02000AE6 RID: 2790
	public class vtkNonOverlappingAMR : vtkUniformGridAMR
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D784 RID: 120708 RVA: 0x00299CDA File Offset: 0x00297EDA
		static vtkNonOverlappingAMR()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNonOverlappingAMR.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNonOverlappingAMR"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D785 RID: 120709 RVA: 0x00299D02 File Offset: 0x00297F02
		public vtkNonOverlappingAMR(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D786 RID: 120710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMR_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D787 RID: 120711 RVA: 0x00299D10 File Offset: 0x00297F10
		public new static vtkNonOverlappingAMR New()
		{
			vtkNonOverlappingAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMR.vtkNonOverlappingAMR_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D788 RID: 120712 RVA: 0x00299D64 File Offset: 0x00297F64
		public vtkNonOverlappingAMR() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNonOverlappingAMR.vtkNonOverlappingAMR_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D789 RID: 120713 RVA: 0x00299DA8 File Offset: 0x00297FA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D78A RID: 120714
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMR_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D78B RID: 120715 RVA: 0x00299DB4 File Offset: 0x00297FB4
		public new static vtkNonOverlappingAMR GetData(vtkInformation info)
		{
			vtkNonOverlappingAMR vtkNonOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMR.vtkNonOverlappingAMR_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonOverlappingAMR = (vtkNonOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonOverlappingAMR.Register(null);
				}
			}
			return vtkNonOverlappingAMR;
		}

		// Token: 0x0601D78C RID: 120716
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMR_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D78D RID: 120717 RVA: 0x00299E34 File Offset: 0x00298034
		public new static vtkNonOverlappingAMR GetData(vtkInformationVector v, int i)
		{
			vtkNonOverlappingAMR vtkNonOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMR.vtkNonOverlappingAMR_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonOverlappingAMR = (vtkNonOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonOverlappingAMR.Register(null);
				}
			}
			return vtkNonOverlappingAMR;
		}

		// Token: 0x0601D78E RID: 120718
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonOverlappingAMR_GetDataObjectType_03(HandleRef pThis);

		/// <summary>
		/// Returns object type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601D78F RID: 120719 RVA: 0x00299EB4 File Offset: 0x002980B4
		public override int GetDataObjectType()
		{
			return vtkNonOverlappingAMR.vtkNonOverlappingAMR_GetDataObjectType_03(base.GetCppThis());
		}

		// Token: 0x0601D790 RID: 120720
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonOverlappingAMR_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D791 RID: 120721 RVA: 0x00299ED4 File Offset: 0x002980D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNonOverlappingAMR.vtkNonOverlappingAMR_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601D792 RID: 120722
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonOverlappingAMR_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D793 RID: 120723 RVA: 0x00299EF4 File Offset: 0x002980F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNonOverlappingAMR.vtkNonOverlappingAMR_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601D794 RID: 120724
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonOverlappingAMR_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D795 RID: 120725 RVA: 0x00299F10 File Offset: 0x00298110
		public override int IsA(string type)
		{
			return vtkNonOverlappingAMR.vtkNonOverlappingAMR_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601D796 RID: 120726
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonOverlappingAMR_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D797 RID: 120727 RVA: 0x00299F30 File Offset: 0x00298130
		public new static int IsTypeOf(string type)
		{
			return vtkNonOverlappingAMR.vtkNonOverlappingAMR_IsTypeOf_07(type);
		}

		// Token: 0x0601D798 RID: 120728
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMR_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D799 RID: 120729 RVA: 0x00299F4C File Offset: 0x0029814C
		public new vtkNonOverlappingAMR NewInstance()
		{
			vtkNonOverlappingAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMR.vtkNonOverlappingAMR_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D79A RID: 120730
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMR_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D79B RID: 120731 RVA: 0x00299FA8 File Offset: 0x002981A8
		public new static vtkNonOverlappingAMR SafeDownCast(vtkObjectBase o)
		{
			vtkNonOverlappingAMR vtkNonOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMR.vtkNonOverlappingAMR_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonOverlappingAMR = (vtkNonOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonOverlappingAMR.Register(null);
				}
			}
			return vtkNonOverlappingAMR;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF3 RID: 7923
		public new const string MRFullTypeName = "Kitware.VTK.vtkNonOverlappingAMR";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF4 RID: 7924
		public new static readonly string MRClassNameKey = "class vtkNonOverlappingAMR";
	}
}
