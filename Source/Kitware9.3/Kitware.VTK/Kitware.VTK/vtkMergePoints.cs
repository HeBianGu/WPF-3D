using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergePoints
	/// </summary>
	/// <remarks>
	///    merge exactly coincident points
	///
	/// vtkMergePoints is a locator object to quickly locate points in 3D.
	/// The primary difference between vtkMergePoints and its superclass
	/// vtkPointLocator is that vtkMergePoints merges precisely coincident points
	/// and is therefore much faster.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCleanPolyData
	/// </seealso>
	// Token: 0x02000423 RID: 1059
	public class vtkMergePoints : vtkPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C7AB RID: 51115 RVA: 0x00115ABD File Offset: 0x00113CBD
		static vtkMergePoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergePoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergePoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7AC RID: 51116 RVA: 0x00115AE5 File Offset: 0x00113CE5
		public vtkMergePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C7AD RID: 51117
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7AE RID: 51118 RVA: 0x00115AF4 File Offset: 0x00113CF4
		public new static vtkMergePoints New()
		{
			vtkMergePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergePoints.vtkMergePoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7AF RID: 51119 RVA: 0x00115B48 File Offset: 0x00113D48
		public vtkMergePoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergePoints.vtkMergePoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7B0 RID: 51120 RVA: 0x00115B8C File Offset: 0x00113D8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C7B1 RID: 51121
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergePoints_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7B2 RID: 51122 RVA: 0x00115B98 File Offset: 0x00113D98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergePoints.vtkMergePoints_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C7B3 RID: 51123
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergePoints_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7B4 RID: 51124 RVA: 0x00115BB8 File Offset: 0x00113DB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergePoints.vtkMergePoints_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C7B5 RID: 51125
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergePoints_InsertUniquePoint_03(HandleRef pThis, IntPtr x, ref long ptId);

		/// <summary>
		/// Determine whether point given by x[3] has been inserted into points list.
		/// Return 0 if point was already in the list, otherwise return 1. If the
		/// point was not in the list, it will be ADDED.  In either case, the id of
		/// the point (newly inserted or not) is returned in the ptId argument.
		/// Note this combines the functionality of IsInsertedPoint() followed
		/// by a call to InsertNextPoint().
		/// </summary>
		// Token: 0x0600C7B6 RID: 51126 RVA: 0x00115BD4 File Offset: 0x00113DD4
		public override int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkMergePoints.vtkMergePoints_InsertUniquePoint_03(base.GetCppThis(), x, ref ptId);
		}

		// Token: 0x0600C7B7 RID: 51127
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergePoints_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7B8 RID: 51128 RVA: 0x00115BF8 File Offset: 0x00113DF8
		public override int IsA(string type)
		{
			return vtkMergePoints.vtkMergePoints_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C7B9 RID: 51129
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergePoints_IsInsertedPoint_05(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Determine whether point given by x[3] has been inserted into points list.
		/// Return id of previously inserted point if this is true, otherwise return
		/// -1.
		/// </summary>
		// Token: 0x0600C7BA RID: 51130 RVA: 0x00115C18 File Offset: 0x00113E18
		public override long IsInsertedPoint(IntPtr x)
		{
			return vtkMergePoints.vtkMergePoints_IsInsertedPoint_05(base.GetCppThis(), x);
		}

		// Token: 0x0600C7BB RID: 51131
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergePoints_IsInsertedPoint_06(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Determine whether point given by x[3] has been inserted into points list.
		/// Return id of previously inserted point if this is true, otherwise return
		/// -1.
		/// </summary>
		// Token: 0x0600C7BC RID: 51132 RVA: 0x00115C38 File Offset: 0x00113E38
		public override long IsInsertedPoint(double x, double y, double z)
		{
			return vtkMergePoints.vtkMergePoints_IsInsertedPoint_06(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600C7BD RID: 51133
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergePoints_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7BE RID: 51134 RVA: 0x00115C5C File Offset: 0x00113E5C
		public new static int IsTypeOf(string type)
		{
			return vtkMergePoints.vtkMergePoints_IsTypeOf_07(type);
		}

		// Token: 0x0600C7BF RID: 51135
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergePoints_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7C0 RID: 51136 RVA: 0x00115C78 File Offset: 0x00113E78
		public new vtkMergePoints NewInstance()
		{
			vtkMergePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergePoints.vtkMergePoints_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C7C1 RID: 51137
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergePoints_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7C2 RID: 51138 RVA: 0x00115CD4 File Offset: 0x00113ED4
		public new static vtkMergePoints SafeDownCast(vtkObjectBase o)
		{
			vtkMergePoints vtkMergePoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergePoints.vtkMergePoints_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergePoints = (vtkMergePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergePoints.Register(null);
				}
			}
			return vtkMergePoints;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED7 RID: 3799
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergePoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED8 RID: 3800
		public new static readonly string MRClassNameKey = "class vtkMergePoints";
	}
}
