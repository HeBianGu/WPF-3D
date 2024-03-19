using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNonMergingPointLocator
	/// </summary>
	/// <remarks>
	///    direct / check-free point insertion.
	///
	///
	///  As a special sub-class of vtkPointLocator, vtkNonMergingPointLocator is
	///  intended for direct / check-free insertion of points into a vtkPoints
	///  object. In other words, any given point is always directly inserted.
	///  The name emphasizes the difference between this class and its sibling
	///  class vtkMergePoints in that the latter class performs check-based zero
	///  tolerance point insertion (or to 'merge' exactly duplicate / coincident
	///  points) by exploiting the uniform bin mechanism employed by the parent
	///  class vtkPointLocator. vtkPointLocator allows for generic (zero and non-
	///  zero) tolerance point insertion as well as point location.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkIncrementalPointLocator vtkPointLocator vtkMergePoints
	/// </seealso>
	// Token: 0x02000A89 RID: 2697
	public class vtkNonMergingPointLocator : vtkPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C404 RID: 115716 RVA: 0x0027AD84 File Offset: 0x00278F84
		static vtkNonMergingPointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNonMergingPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNonMergingPointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C405 RID: 115717 RVA: 0x0027ADAC File Offset: 0x00278FAC
		public vtkNonMergingPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C406 RID: 115718
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonMergingPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C407 RID: 115719 RVA: 0x0027ADBC File Offset: 0x00278FBC
		public new static vtkNonMergingPointLocator New()
		{
			vtkNonMergingPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonMergingPointLocator.vtkNonMergingPointLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C408 RID: 115720 RVA: 0x0027AE10 File Offset: 0x00279010
		public vtkNonMergingPointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNonMergingPointLocator.vtkNonMergingPointLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C409 RID: 115721 RVA: 0x0027AE54 File Offset: 0x00279054
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C40A RID: 115722
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonMergingPointLocator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C40B RID: 115723 RVA: 0x0027AE60 File Offset: 0x00279060
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601C40C RID: 115724
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonMergingPointLocator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C40D RID: 115725 RVA: 0x0027AE80 File Offset: 0x00279080
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601C40E RID: 115726
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonMergingPointLocator_InsertUniquePoint_03(HandleRef pThis, IntPtr x, ref long ptId);

		/// <summary>
		/// Determine whether a given point x has been inserted into the points list.
		/// Return 0 if a duplicate has been inserted in the list, or 1 else. Note
		/// this function always returns 1 since any point is always inserted. The
		/// index of the point is returned via ptId.
		/// </summary>
		// Token: 0x0601C40F RID: 115727 RVA: 0x0027AE9C File Offset: 0x0027909C
		public override int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_InsertUniquePoint_03(base.GetCppThis(), x, ref ptId);
		}

		// Token: 0x0601C410 RID: 115728
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonMergingPointLocator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C411 RID: 115729 RVA: 0x0027AEC0 File Offset: 0x002790C0
		public override int IsA(string type)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C412 RID: 115730
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonMergingPointLocator_IsInsertedPoint_05(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Determine whether a given point x has been inserted into the points list.
		/// Return the id of the already inserted point if it is true, or -1 else.
		/// Note this function always returns -1 since any point is always inserted.
		/// </summary>
		// Token: 0x0601C413 RID: 115731 RVA: 0x0027AEE0 File Offset: 0x002790E0
		public override long IsInsertedPoint(IntPtr arg0)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsInsertedPoint_05(base.GetCppThis(), arg0);
		}

		// Token: 0x0601C414 RID: 115732
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonMergingPointLocator_IsInsertedPoint_06(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Determine whether a given point x has been inserted into the points list.
		/// Return the id of the already inserted point if it is true, or -1 else.
		/// Note this function always returns -1 since any point is always inserted.
		/// </summary>
		// Token: 0x0601C415 RID: 115733 RVA: 0x0027AF00 File Offset: 0x00279100
		public override long IsInsertedPoint(double arg0, double arg1, double arg2)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsInsertedPoint_06(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0601C416 RID: 115734
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonMergingPointLocator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C417 RID: 115735 RVA: 0x0027AF24 File Offset: 0x00279124
		public new static int IsTypeOf(string type)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsTypeOf_07(type);
		}

		// Token: 0x0601C418 RID: 115736
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonMergingPointLocator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C419 RID: 115737 RVA: 0x0027AF40 File Offset: 0x00279140
		public new vtkNonMergingPointLocator NewInstance()
		{
			vtkNonMergingPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonMergingPointLocator.vtkNonMergingPointLocator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C41A RID: 115738
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonMergingPointLocator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C41B RID: 115739 RVA: 0x0027AF9C File Offset: 0x0027919C
		public new static vtkNonMergingPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkNonMergingPointLocator vtkNonMergingPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonMergingPointLocator.vtkNonMergingPointLocator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonMergingPointLocator = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonMergingPointLocator.Register(null);
				}
			}
			return vtkNonMergingPointLocator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E0E RID: 7694
		public new const string MRFullTypeName = "Kitware.VTK.vtkNonMergingPointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E0F RID: 7695
		public new static readonly string MRClassNameKey = "class vtkNonMergingPointLocator";
	}
}
