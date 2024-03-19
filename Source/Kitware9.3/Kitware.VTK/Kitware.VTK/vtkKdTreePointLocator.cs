using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKdTreePointLocator
	/// </summary>
	/// <remarks>
	///    class to quickly locate points in 3-space
	///
	/// vtkKdTreePointLocator is a wrapper class that derives from
	/// vtkAbstractPointLocator and calls the search functions in vtkKdTree.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkKdTree
	/// </seealso>
	// Token: 0x02000A76 RID: 2678
	public class vtkKdTreePointLocator : vtkAbstractPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C126 RID: 114982 RVA: 0x002757FB File Offset: 0x002739FB
		static vtkKdTreePointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdTreePointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTreePointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C127 RID: 114983 RVA: 0x00275823 File Offset: 0x00273A23
		public vtkKdTreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C128 RID: 114984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C129 RID: 114985 RVA: 0x00275834 File Offset: 0x00273A34
		public new static vtkKdTreePointLocator New()
		{
			vtkKdTreePointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTreePointLocator.vtkKdTreePointLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C12A RID: 114986 RVA: 0x00275888 File Offset: 0x00273A88
		public vtkKdTreePointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKdTreePointLocator.vtkKdTreePointLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C12B RID: 114987 RVA: 0x002758CC File Offset: 0x00273ACC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C12C RID: 114988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreePointLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601C12D RID: 114989 RVA: 0x002758D7 File Offset: 0x00273AD7
		public override void BuildLocator()
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0601C12E RID: 114990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreePointLocator_FindClosestNPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest
		/// N points to a position. A faster method could be created that returned
		/// N close points to a position, but necessarily the exact N closest.
		/// The returned points are sorted from closest to farthest.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601C12F RID: 114991 RVA: 0x002758E8 File Offset: 0x00273AE8
		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_FindClosestNPoints_02(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601C130 RID: 114992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTreePointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a position x, return the id of the point closest to it. Alternative
		/// method requires separate x-y-z values.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601C131 RID: 114993 RVA: 0x0027591C File Offset: 0x00273B1C
		public override long FindClosestPoint(IntPtr x)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_FindClosestPoint_03(base.GetCppThis(), x);
		}

		// Token: 0x0601C132 RID: 114994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTreePointLocator_FindClosestPointWithinRadius_04(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point
		/// closest to the point in that radius.
		/// dist2 returns the squared distance to the point.
		/// </summary>
		// Token: 0x0601C133 RID: 114995 RVA: 0x0027593C File Offset: 0x00273B3C
		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_FindClosestPointWithinRadius_04(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0601C134 RID: 114996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreePointLocator_FindPointsWithinRadius_05(HandleRef pThis, double R, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius R of position x.
		/// The result is not sorted in any specific manner.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601C135 RID: 114997 RVA: 0x00275960 File Offset: 0x00273B60
		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_FindPointsWithinRadius_05(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601C136 RID: 114998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreePointLocator_ForceBuildLocator_06(HandleRef pThis);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601C137 RID: 114999 RVA: 0x00275991 File Offset: 0x00273B91
		public override void ForceBuildLocator()
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_ForceBuildLocator_06(base.GetCppThis());
		}

		// Token: 0x0601C138 RID: 115000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreePointLocator_FreeSearchStructure_07(HandleRef pThis);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601C139 RID: 115001 RVA: 0x002759A0 File Offset: 0x00273BA0
		public override void FreeSearchStructure()
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_FreeSearchStructure_07(base.GetCppThis());
		}

		// Token: 0x0601C13A RID: 115002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreePointLocator_GenerateRepresentation_08(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601C13B RID: 115003 RVA: 0x002759B0 File Offset: 0x00273BB0
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_GenerateRepresentation_08(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601C13C RID: 115004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTreePointLocator_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C13D RID: 115005 RVA: 0x002759E0 File Offset: 0x00273BE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601C13E RID: 115006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTreePointLocator_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C13F RID: 115007 RVA: 0x00275A00 File Offset: 0x00273C00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601C140 RID: 115008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTreePointLocator_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C141 RID: 115009 RVA: 0x00275A1C File Offset: 0x00273C1C
		public override int IsA(string type)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601C142 RID: 115010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTreePointLocator_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C143 RID: 115011 RVA: 0x00275A3C File Offset: 0x00273C3C
		public new static int IsTypeOf(string type)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_IsTypeOf_12(type);
		}

		// Token: 0x0601C144 RID: 115012
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreePointLocator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C145 RID: 115013 RVA: 0x00275A58 File Offset: 0x00273C58
		public new vtkKdTreePointLocator NewInstance()
		{
			vtkKdTreePointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTreePointLocator.vtkKdTreePointLocator_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C146 RID: 115014
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreePointLocator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C147 RID: 115015 RVA: 0x00275AB4 File Offset: 0x00273CB4
		public new static vtkKdTreePointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkKdTreePointLocator vtkKdTreePointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTreePointLocator.vtkKdTreePointLocator_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTreePointLocator = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTreePointLocator.Register(null);
				}
			}
			return vtkKdTreePointLocator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE3 RID: 7651
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdTreePointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE4 RID: 7652
		public new static readonly string MRClassNameKey = "class vtkKdTreePointLocator";
	}
}
