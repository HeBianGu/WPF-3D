using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCoincidentPoints
	/// </summary>
	/// <remarks>
	///    contains an octree of labels
	///
	///
	/// This class provides a collection of points that is organized such that
	/// each coordinate is stored with a set of point id's of points that are
	/// all coincident.
	/// </remarks>
	// Token: 0x02000885 RID: 2181
	public class vtkCoincidentPoints : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016A82 RID: 92802 RVA: 0x001FDD5F File Offset: 0x001FBF5F
		static vtkCoincidentPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCoincidentPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoincidentPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016A83 RID: 92803 RVA: 0x001FDD87 File Offset: 0x001FBF87
		public vtkCoincidentPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016A84 RID: 92804
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoincidentPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A85 RID: 92805 RVA: 0x001FDD98 File Offset: 0x001FBF98
		public new static vtkCoincidentPoints New()
		{
			vtkCoincidentPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A86 RID: 92806 RVA: 0x001FDDEC File Offset: 0x001FBFEC
		public vtkCoincidentPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCoincidentPoints.vtkCoincidentPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016A87 RID: 92807 RVA: 0x001FDE30 File Offset: 0x001FC030
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016A88 RID: 92808
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoincidentPoints_AddPoint_01(HandleRef pThis, long Id, IntPtr point);

		/// <summary>
		/// Accumulates a set of Ids in a map where the point coordinate
		/// is the key. All Ids in a given map entry are thus coincident.
		/// @param Id - a unique Id for the given \a point that will be stored in an vtkIdList.
		/// @param[in] point - the point coordinate that we will store in the map to test if any other
		/// points are coincident with it.
		/// </summary>
		// Token: 0x06016A89 RID: 92809 RVA: 0x001FDE3B File Offset: 0x001FC03B
		public void AddPoint(long Id, IntPtr point)
		{
			vtkCoincidentPoints.vtkCoincidentPoints_AddPoint_01(base.GetCppThis(), Id, point);
		}

		// Token: 0x06016A8A RID: 92810
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoincidentPoints_Clear_02(HandleRef pThis);

		/// <summary>
		/// Clear the maps for reuse. This should be called if the caller
		/// might reuse this class (another executive pass for instance).
		/// </summary>
		// Token: 0x06016A8B RID: 92811 RVA: 0x001FDE4C File Offset: 0x001FC04C
		public void Clear()
		{
			vtkCoincidentPoints.vtkCoincidentPoints_Clear_02(base.GetCppThis());
		}

		// Token: 0x06016A8C RID: 92812
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoincidentPoints_GetCoincidentPointIds_03(HandleRef pThis, IntPtr point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the list of point Ids that are coincident with the given \a point.
		/// @param[in] point - the coordinate of coincident points we want to retrieve.
		/// </summary>
		// Token: 0x06016A8D RID: 92813 RVA: 0x001FDE5C File Offset: 0x001FC05C
		public vtkIdList GetCoincidentPointIds(IntPtr point)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_GetCoincidentPointIds_03(base.GetCppThis(), point, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x06016A8E RID: 92814
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoincidentPoints_GetNextCoincidentPointIds_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Used to iterate the sets of coincident points within the map.
		/// InitTraversal must be called first or nullptr will always be returned.
		/// </summary>
		// Token: 0x06016A8F RID: 92815 RVA: 0x001FDECC File Offset: 0x001FC0CC
		public vtkIdList GetNextCoincidentPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_GetNextCoincidentPointIds_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x06016A90 RID: 92816
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoincidentPoints_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A91 RID: 92817 RVA: 0x001FDF3C File Offset: 0x001FC13C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCoincidentPoints.vtkCoincidentPoints_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06016A92 RID: 92818
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoincidentPoints_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A93 RID: 92819 RVA: 0x001FDF5C File Offset: 0x001FC15C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCoincidentPoints.vtkCoincidentPoints_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06016A94 RID: 92820
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoincidentPoints_InitTraversal_07(HandleRef pThis);

		/// <summary>
		/// Initialize iteration to the beginning of the coincident point map.
		/// </summary>
		// Token: 0x06016A95 RID: 92821 RVA: 0x001FDF76 File Offset: 0x001FC176
		public void InitTraversal()
		{
			vtkCoincidentPoints.vtkCoincidentPoints_InitTraversal_07(base.GetCppThis());
		}

		// Token: 0x06016A96 RID: 92822
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoincidentPoints_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A97 RID: 92823 RVA: 0x001FDF88 File Offset: 0x001FC188
		public override int IsA(string type)
		{
			return vtkCoincidentPoints.vtkCoincidentPoints_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06016A98 RID: 92824
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoincidentPoints_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A99 RID: 92825 RVA: 0x001FDFA8 File Offset: 0x001FC1A8
		public new static int IsTypeOf(string type)
		{
			return vtkCoincidentPoints.vtkCoincidentPoints_IsTypeOf_09(type);
		}

		// Token: 0x06016A9A RID: 92826
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoincidentPoints_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A9B RID: 92827 RVA: 0x001FDFC4 File Offset: 0x001FC1C4
		public new vtkCoincidentPoints NewInstance()
		{
			vtkCoincidentPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016A9C RID: 92828
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoincidentPoints_RemoveNonCoincidentPoints_12(HandleRef pThis);

		/// <summary>
		/// Iterate through all added points and remove any entries that have
		/// no coincident points (only a single point Id).
		/// </summary>
		// Token: 0x06016A9D RID: 92829 RVA: 0x001FE01E File Offset: 0x001FC21E
		public void RemoveNonCoincidentPoints()
		{
			vtkCoincidentPoints.vtkCoincidentPoints_RemoveNonCoincidentPoints_12(base.GetCppThis());
		}

		// Token: 0x06016A9E RID: 92830
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoincidentPoints_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A9F RID: 92831 RVA: 0x001FE030 File Offset: 0x001FC230
		public new static vtkCoincidentPoints SafeDownCast(vtkObjectBase o)
		{
			vtkCoincidentPoints vtkCoincidentPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoincidentPoints = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoincidentPoints.Register(null);
				}
			}
			return vtkCoincidentPoints;
		}

		// Token: 0x06016AA0 RID: 92832
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoincidentPoints_SpiralPoints_14(long num, HandleRef offsets);

		/// <summary>
		/// Calculate \a num points, at a regular interval, along a parametric
		/// spiral. Note this spiral is only in two dimensions having a constant
		/// z value.
		/// </summary>
		// Token: 0x06016AA1 RID: 92833 RVA: 0x001FE0B0 File Offset: 0x001FC2B0
		public static void SpiralPoints(long num, vtkPoints offsets)
		{
			vtkCoincidentPoints.vtkCoincidentPoints_SpiralPoints_14(num, (offsets == null) ? default(HandleRef) : offsets.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400196B RID: 6507
		public new const string MRFullTypeName = "Kitware.VTK.vtkCoincidentPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400196C RID: 6508
		public new static readonly string MRClassNameKey = "class vtkCoincidentPoints";
	}
}
