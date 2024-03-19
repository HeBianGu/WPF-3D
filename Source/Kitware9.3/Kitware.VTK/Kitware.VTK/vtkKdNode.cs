using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKdNode
	/// </summary>
	/// <remarks>
	///    This class represents a single spatial region
	///     in an 3D axis aligned binary spatial partitioning.  It is assumed
	///     the region bounds some set of points.  Regions are represented
	///     as nodes in a binary tree.
	///
	///
	///
	/// </remarks>
	/// <seealso>
	///
	///      vtkKdTree vtkOBSPCuts
	/// </seealso>
	// Token: 0x02000A75 RID: 2677
	public class vtkKdNode : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C0BC RID: 114876 RVA: 0x00274F15 File Offset: 0x00273115
		static vtkKdNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C0BD RID: 114877 RVA: 0x00274F3D File Offset: 0x0027313D
		public vtkKdNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C0BE RID: 114878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0BF RID: 114879 RVA: 0x00274F4C File Offset: 0x0027314C
		public new static vtkKdNode New()
		{
			vtkKdNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdNode.vtkKdNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0C0 RID: 114880 RVA: 0x00274FA0 File Offset: 0x002731A0
		public vtkKdNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKdNode.vtkKdNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C0C1 RID: 114881 RVA: 0x00274FE4 File Offset: 0x002731E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C0C2 RID: 114882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_AddChildNodes_01(HandleRef pThis, HandleRef left, HandleRef right);

		/// <summary>
		/// Add the left and right children.
		/// </summary>
		// Token: 0x0601C0C3 RID: 114883 RVA: 0x00274FF0 File Offset: 0x002731F0
		public void AddChildNodes(vtkKdNode left, vtkKdNode right)
		{
			vtkKdNode.vtkKdNode_AddChildNodes_01(base.GetCppThis(), (left == null) ? default(HandleRef) : left.GetCppThis(), (right == null) ? default(HandleRef) : right.GetCppThis());
		}

		// Token: 0x0601C0C4 RID: 114884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_ContainsBox_02(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds);

		/// <summary>
		/// Return 1 if this spatial region entirely contains a box specified
		/// by it's bounds. Use the possibly smaller
		/// bounds of the points within the region if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C0C5 RID: 114885 RVA: 0x00275034 File Offset: 0x00273234
		public int ContainsBox(double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_ContainsBox_02(base.GetCppThis(), x1, x2, y1, y2, z1, z2, useDataBounds);
		}

		// Token: 0x0601C0C6 RID: 114886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_ContainsPoint_03(HandleRef pThis, double x, double y, double z, int useDataBounds);

		/// <summary>
		/// Return 1 if this spatial region entirely contains the given point.
		/// Use the possibly smaller bounds of the points within the region
		/// if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C0C7 RID: 114887 RVA: 0x00275060 File Offset: 0x00273260
		public int ContainsPoint(double x, double y, double z, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_ContainsPoint_03(base.GetCppThis(), x, y, z, useDataBounds);
		}

		// Token: 0x0601C0C8 RID: 114888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_DeleteChildNodes_04(HandleRef pThis);

		/// <summary>
		/// Delete the left and right children.
		/// </summary>
		// Token: 0x0601C0C9 RID: 114889 RVA: 0x00275084 File Offset: 0x00273284
		public void DeleteChildNodes()
		{
			vtkKdNode.vtkKdNode_DeleteChildNodes_04(base.GetCppThis());
		}

		// Token: 0x0601C0CA RID: 114890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_GetBounds_05(HandleRef pThis, IntPtr b);

		/// <summary>
		/// Set/Get the bounds of the spatial region represented by this node.
		/// Caller allocates storage for 6-vector in GetBounds.
		/// </summary>
		// Token: 0x0601C0CB RID: 114891 RVA: 0x00275093 File Offset: 0x00273293
		public void GetBounds(IntPtr b)
		{
			vtkKdNode.vtkKdNode_GetBounds_05(base.GetCppThis(), b);
		}

		// Token: 0x0601C0CC RID: 114892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_GetDataBounds_06(HandleRef pThis, IntPtr b);

		/// <summary>
		/// Set/Get the bounds of the points contained in this spatial region.
		/// This may be smaller than the bounds of the region itself.
		/// Caller allocates storage for 6-vector in GetDataBounds.
		/// </summary>
		// Token: 0x0601C0CD RID: 114893 RVA: 0x002750A3 File Offset: 0x002732A3
		public void GetDataBounds(IntPtr b)
		{
			vtkKdNode.vtkKdNode_GetDataBounds_06(base.GetCppThis(), b);
		}

		// Token: 0x0601C0CE RID: 114894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_GetDim_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the dimension along which this region is divided.
		/// (0 - x, 1 - y, 2 - z, 3 - leaf node (default)).
		/// </summary>
		// Token: 0x0601C0CF RID: 114895 RVA: 0x002750B4 File Offset: 0x002732B4
		public virtual int GetDim()
		{
			return vtkKdNode.vtkKdNode_GetDim_07(base.GetCppThis());
		}

		// Token: 0x0601C0D0 RID: 114896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKdNode_GetDistance2ToBoundary_08(HandleRef pThis, double x, double y, double z, int useDataBounds);

		/// <summary>
		/// Calculate the distance squared from any point to the boundary of this
		/// region.  Use the boundary of the points within the region if useDataBounds
		/// is non-zero.
		/// </summary>
		// Token: 0x0601C0D1 RID: 114897 RVA: 0x002750D4 File Offset: 0x002732D4
		public double GetDistance2ToBoundary(double x, double y, double z, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_GetDistance2ToBoundary_08(base.GetCppThis(), x, y, z, useDataBounds);
		}

		// Token: 0x0601C0D2 RID: 114898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKdNode_GetDistance2ToBoundary_09(HandleRef pThis, double x, double y, double z, IntPtr boundaryPt, int useDataBounds);

		/// <summary>
		/// Calculate the distance squared from any point to the boundary of this
		/// region.  Use the boundary of the points within the region if useDataBounds
		/// is non-zero.  Set boundaryPt to the point on the boundary.
		/// </summary>
		// Token: 0x0601C0D3 RID: 114899 RVA: 0x002750F8 File Offset: 0x002732F8
		public double GetDistance2ToBoundary(double x, double y, double z, IntPtr boundaryPt, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_GetDistance2ToBoundary_09(base.GetCppThis(), x, y, z, boundaryPt, useDataBounds);
		}

		// Token: 0x0601C0D4 RID: 114900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKdNode_GetDistance2ToInnerBoundary_10(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Calculate the distance from the specified point (which is required to
		/// be inside this spatial region) to an interior boundary.  An interior
		/// boundary is one that is not also an boundary of the entire space
		/// partitioned by the tree of vtkKdNode's.
		/// </summary>
		// Token: 0x0601C0D5 RID: 114901 RVA: 0x00275120 File Offset: 0x00273320
		public double GetDistance2ToInnerBoundary(double x, double y, double z)
		{
			return vtkKdNode.vtkKdNode_GetDistance2ToInnerBoundary_10(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601C0D6 RID: 114902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKdNode_GetDivisionPosition_11(HandleRef pThis);

		/// <summary>
		/// Get the location of the division plane along the axis the region
		/// is divided.  See also GetDim().  The result is undertermined if
		/// this node is not divided (a leaf node).
		/// </summary>
		// Token: 0x0601C0D7 RID: 114903 RVA: 0x00275144 File Offset: 0x00273344
		public virtual double GetDivisionPosition()
		{
			return vtkKdNode.vtkKdNode_GetDivisionPosition_11(base.GetCppThis());
		}

		// Token: 0x0601C0D8 RID: 114904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_GetID_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the ID associated with the region described by this node.  If
		/// this is not a leaf node, this value should be -1.
		/// </summary>
		// Token: 0x0601C0D9 RID: 114905 RVA: 0x00275164 File Offset: 0x00273364
		public virtual int GetID()
		{
			return vtkKdNode.vtkKdNode_GetID_12(base.GetCppThis());
		}

		// Token: 0x0601C0DA RID: 114906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_GetLeft_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a pointer to the left child of this node.
		/// </summary>
		// Token: 0x0601C0DB RID: 114907 RVA: 0x00275184 File Offset: 0x00273384
		public virtual vtkKdNode GetLeft()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetLeft_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		// Token: 0x0601C0DC RID: 114908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_GetMaxBounds_14(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
		/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C0DD RID: 114909 RVA: 0x002751F4 File Offset: 0x002733F4
		public double[] GetMaxBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMaxBounds_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C0DE RID: 114910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_GetMaxDataBounds_15(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
		/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C0DF RID: 114911 RVA: 0x0027523C File Offset: 0x0027343C
		public double[] GetMaxDataBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMaxDataBounds_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C0E0 RID: 114912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_GetMaxID_16(HandleRef pThis);

		/// <summary>
		/// If this node is not a leaf node, there are leaf nodes below it whose
		/// regions represent a partitioning of this region.  The IDs of these
		/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
		/// the leaf nodes below this node.  If this is already a leaf node, these
		/// values should be the same as the ID.
		/// </summary>
		// Token: 0x0601C0E1 RID: 114913 RVA: 0x00275284 File Offset: 0x00273484
		public virtual int GetMaxID()
		{
			return vtkKdNode.vtkKdNode_GetMaxID_16(base.GetCppThis());
		}

		// Token: 0x0601C0E2 RID: 114914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_GetMinBounds_17(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
		/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C0E3 RID: 114915 RVA: 0x002752A4 File Offset: 0x002734A4
		public double[] GetMinBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMinBounds_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C0E4 RID: 114916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_GetMinDataBounds_18(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
		/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C0E5 RID: 114917 RVA: 0x002752EC File Offset: 0x002734EC
		public double[] GetMinDataBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMinDataBounds_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C0E6 RID: 114918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_GetMinID_19(HandleRef pThis);

		/// <summary>
		/// If this node is not a leaf node, there are leaf nodes below it whose
		/// regions represent a partitioning of this region.  The IDs of these
		/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
		/// the leaf nodes below this node.  If this is already a leaf node, these
		/// values should be the same as the ID.
		/// </summary>
		// Token: 0x0601C0E7 RID: 114919 RVA: 0x00275334 File Offset: 0x00273534
		public virtual int GetMinID()
		{
			return vtkKdNode.vtkKdNode_GetMinID_19(base.GetCppThis());
		}

		// Token: 0x0601C0E8 RID: 114920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdNode_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0E9 RID: 114921 RVA: 0x00275354 File Offset: 0x00273554
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKdNode.vtkKdNode_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0601C0EA RID: 114922
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdNode_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0EB RID: 114923 RVA: 0x00275374 File Offset: 0x00273574
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKdNode.vtkKdNode_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0601C0EC RID: 114924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_GetNumberOfPoints_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of points contained in this region.
		/// </summary>
		// Token: 0x0601C0ED RID: 114925 RVA: 0x00275390 File Offset: 0x00273590
		public virtual int GetNumberOfPoints()
		{
			return vtkKdNode.vtkKdNode_GetNumberOfPoints_22(base.GetCppThis());
		}

		// Token: 0x0601C0EE RID: 114926
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_GetRight_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a pointer to the right child of this node.
		/// </summary>
		// Token: 0x0601C0EF RID: 114927 RVA: 0x002753B0 File Offset: 0x002735B0
		public virtual vtkKdNode GetRight()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetRight_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		// Token: 0x0601C0F0 RID: 114928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_GetUp_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a pointer to the parent of this node.
		/// </summary>
		// Token: 0x0601C0F1 RID: 114929 RVA: 0x00275420 File Offset: 0x00273620
		public virtual vtkKdNode GetUp()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetUp_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		// Token: 0x0601C0F2 RID: 114930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_IntersectsBox_25(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds);

		/// <summary>
		/// Return 1 if this spatial region intersects the axis-aligned box given
		/// by the bounds passed in.  Use the possibly smaller bounds of the points
		/// within the region if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C0F3 RID: 114931 RVA: 0x00275490 File Offset: 0x00273690
		public int IntersectsBox(double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsBox_25(base.GetCppThis(), x1, x2, y1, y2, z1, z2, useDataBounds);
		}

		// Token: 0x0601C0F4 RID: 114932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_IntersectsCell_26(HandleRef pThis, HandleRef cell, int useDataBounds, int cellRegion, IntPtr cellBounds);

		/// <summary>
		/// Return 1 if the cell specified intersects this region.  If you
		/// already know the ID of the region containing the cell's centroid,
		/// provide that as an argument.  If you already know the bounds of the
		/// cell, provide that as well, in the form of xmin,xmax,ymin,ymax,zmin,
		/// zmax.  Either of these may speed the calculation.
		/// Use the possibly smaller bounds of the points within the region
		/// if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C0F5 RID: 114933 RVA: 0x002754BC File Offset: 0x002736BC
		public int IntersectsCell(vtkCell cell, int useDataBounds, int cellRegion, IntPtr cellBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsCell_26(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), useDataBounds, cellRegion, cellBounds);
		}

		// Token: 0x0601C0F6 RID: 114934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_IntersectsRegion_27(HandleRef pThis, HandleRef pi, int useDataBounds);

		/// <summary>
		/// A vtkPlanesIntersection object represents a convex 3D region bounded
		/// by planes, and it is capable of computing intersections of
		/// boxes with itself.  Return 1 if this spatial region intersects
		/// the spatial region described by the vtkPlanesIntersection object.
		/// Use the possibly smaller bounds of the points within the region
		/// if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C0F7 RID: 114935 RVA: 0x002754F4 File Offset: 0x002736F4
		public int IntersectsRegion(vtkPlanesIntersection pi, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsRegion_27(base.GetCppThis(), (pi == null) ? default(HandleRef) : pi.GetCppThis(), useDataBounds);
		}

		// Token: 0x0601C0F8 RID: 114936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_IntersectsSphere2_28(HandleRef pThis, double x, double y, double z, double rSquared, int useDataBounds);

		/// <summary>
		/// Return 1 if this spatial region intersects a sphere described by
		/// it's center and the square of it's radius. Use the possibly smaller
		/// bounds of the points within the region if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C0F9 RID: 114937 RVA: 0x0027552C File Offset: 0x0027372C
		public int IntersectsSphere2(double x, double y, double z, double rSquared, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsSphere2_28(base.GetCppThis(), x, y, z, rSquared, useDataBounds);
		}

		// Token: 0x0601C0FA RID: 114938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0FB RID: 114939 RVA: 0x00275554 File Offset: 0x00273754
		public override int IsA(string type)
		{
			return vtkKdNode.vtkKdNode_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0601C0FC RID: 114940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdNode_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0FD RID: 114941 RVA: 0x00275574 File Offset: 0x00273774
		public new static int IsTypeOf(string type)
		{
			return vtkKdNode.vtkKdNode_IsTypeOf_30(type);
		}

		// Token: 0x0601C0FE RID: 114942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0FF RID: 114943 RVA: 0x00275590 File Offset: 0x00273790
		public new vtkKdNode NewInstance()
		{
			vtkKdNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdNode.vtkKdNode_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C100 RID: 114944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_PrintNode_33(HandleRef pThis, int depth);

		/// <summary>
		/// For debugging purposes, print out this node.
		/// </summary>
		// Token: 0x0601C101 RID: 114945 RVA: 0x002755EA File Offset: 0x002737EA
		public void PrintNode(int depth)
		{
			vtkKdNode.vtkKdNode_PrintNode_33(base.GetCppThis(), depth);
		}

		// Token: 0x0601C102 RID: 114946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_PrintVerboseNode_34(HandleRef pThis, int depth);

		/// <summary>
		/// For debugging purposes, print out this node.
		/// </summary>
		// Token: 0x0601C103 RID: 114947 RVA: 0x002755FA File Offset: 0x002737FA
		public void PrintVerboseNode(int depth)
		{
			vtkKdNode.vtkKdNode_PrintVerboseNode_34(base.GetCppThis(), depth);
		}

		// Token: 0x0601C104 RID: 114948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdNode_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C105 RID: 114949 RVA: 0x0027560C File Offset: 0x0027380C
		public new static vtkKdNode SafeDownCast(vtkObjectBase o)
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdNode.vtkKdNode_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		// Token: 0x0601C106 RID: 114950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetBounds_36(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

		/// <summary>
		/// Set/Get the bounds of the spatial region represented by this node.
		/// Caller allocates storage for 6-vector in GetBounds.
		/// </summary>
		// Token: 0x0601C107 RID: 114951 RVA: 0x0027568B File Offset: 0x0027388B
		public void SetBounds(double x1, double x2, double y1, double y2, double z1, double z2)
		{
			vtkKdNode.vtkKdNode_SetBounds_36(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		// Token: 0x0601C108 RID: 114952
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetBounds_37(HandleRef pThis, IntPtr b);

		/// <summary>
		/// Set/Get the bounds of the spatial region represented by this node.
		/// Caller allocates storage for 6-vector in GetBounds.
		/// </summary>
		// Token: 0x0601C109 RID: 114953 RVA: 0x002756A3 File Offset: 0x002738A3
		public void SetBounds(IntPtr b)
		{
			vtkKdNode.vtkKdNode_SetBounds_37(base.GetCppThis(), b);
		}

		// Token: 0x0601C10A RID: 114954
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetDataBounds_38(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

		/// <summary>
		/// Set/Get the bounds of the points contained in this spatial region.
		/// This may be smaller than the bounds of the region itself.
		/// Caller allocates storage for 6-vector in GetDataBounds.
		/// </summary>
		// Token: 0x0601C10B RID: 114955 RVA: 0x002756B3 File Offset: 0x002738B3
		public void SetDataBounds(double x1, double x2, double y1, double y2, double z1, double z2)
		{
			vtkKdNode.vtkKdNode_SetDataBounds_38(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		// Token: 0x0601C10C RID: 114956
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetDataBounds_39(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Given a pointer to NumberOfPoints points, set the DataBounds of this
		/// node to the bounds of these points.
		/// </summary>
		// Token: 0x0601C10D RID: 114957 RVA: 0x002756CB File Offset: 0x002738CB
		public void SetDataBounds(IntPtr v)
		{
			vtkKdNode.vtkKdNode_SetDataBounds_39(base.GetCppThis(), v);
		}

		// Token: 0x0601C10E RID: 114958
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetDim_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the dimension along which this region is divided.
		/// (0 - x, 1 - y, 2 - z, 3 - leaf node (default)).
		/// </summary>
		// Token: 0x0601C10F RID: 114959 RVA: 0x002756DB File Offset: 0x002738DB
		public virtual void SetDim(int _arg)
		{
			vtkKdNode.vtkKdNode_SetDim_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C110 RID: 114960
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetID_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the ID associated with the region described by this node.  If
		/// this is not a leaf node, this value should be -1.
		/// </summary>
		// Token: 0x0601C111 RID: 114961 RVA: 0x002756EB File Offset: 0x002738EB
		public virtual void SetID(int _arg)
		{
			vtkKdNode.vtkKdNode_SetID_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C112 RID: 114962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetLeft_42(HandleRef pThis, HandleRef left);

		/// <summary>
		/// Set/Get a pointer to the left child of this node.
		/// </summary>
		// Token: 0x0601C113 RID: 114963 RVA: 0x002756FC File Offset: 0x002738FC
		public void SetLeft(vtkKdNode left)
		{
			vtkKdNode.vtkKdNode_SetLeft_42(base.GetCppThis(), (left == null) ? default(HandleRef) : left.GetCppThis());
		}

		// Token: 0x0601C114 RID: 114964
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetMaxBounds_43(HandleRef pThis, IntPtr mb);

		/// <summary>
		/// Set the xmax, ymax and zmax value of the bounds of this region
		/// </summary>
		// Token: 0x0601C115 RID: 114965 RVA: 0x0027572B File Offset: 0x0027392B
		public void SetMaxBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMaxBounds_43(base.GetCppThis(), mb);
		}

		// Token: 0x0601C116 RID: 114966
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetMaxDataBounds_44(HandleRef pThis, IntPtr mb);

		/// <summary>
		/// Set the xmax, ymax and zmax value of the bounds of this
		/// data within this region
		/// </summary>
		// Token: 0x0601C117 RID: 114967 RVA: 0x0027573B File Offset: 0x0027393B
		public void SetMaxDataBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMaxDataBounds_44(base.GetCppThis(), mb);
		}

		// Token: 0x0601C118 RID: 114968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetMaxID_45(HandleRef pThis, int _arg);

		/// <summary>
		/// If this node is not a leaf node, there are leaf nodes below it whose
		/// regions represent a partitioning of this region.  The IDs of these
		/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
		/// the leaf nodes below this node.  If this is already a leaf node, these
		/// values should be the same as the ID.
		/// </summary>
		// Token: 0x0601C119 RID: 114969 RVA: 0x0027574B File Offset: 0x0027394B
		public virtual void SetMaxID(int _arg)
		{
			vtkKdNode.vtkKdNode_SetMaxID_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C11A RID: 114970
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetMinBounds_46(HandleRef pThis, IntPtr mb);

		/// <summary>
		/// Set the xmin, ymin and zmin value of the bounds of this region
		/// </summary>
		// Token: 0x0601C11B RID: 114971 RVA: 0x0027575B File Offset: 0x0027395B
		public void SetMinBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMinBounds_46(base.GetCppThis(), mb);
		}

		// Token: 0x0601C11C RID: 114972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetMinDataBounds_47(HandleRef pThis, IntPtr mb);

		/// <summary>
		/// Set the xmin, ymin and zmin value of the bounds of this
		/// data within this region
		/// </summary>
		// Token: 0x0601C11D RID: 114973 RVA: 0x0027576B File Offset: 0x0027396B
		public void SetMinDataBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMinDataBounds_47(base.GetCppThis(), mb);
		}

		// Token: 0x0601C11E RID: 114974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetMinID_48(HandleRef pThis, int _arg);

		/// <summary>
		/// If this node is not a leaf node, there are leaf nodes below it whose
		/// regions represent a partitioning of this region.  The IDs of these
		/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
		/// the leaf nodes below this node.  If this is already a leaf node, these
		/// values should be the same as the ID.
		/// </summary>
		// Token: 0x0601C11F RID: 114975 RVA: 0x0027577B File Offset: 0x0027397B
		public virtual void SetMinID(int _arg)
		{
			vtkKdNode.vtkKdNode_SetMinID_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C120 RID: 114976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetNumberOfPoints_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of points contained in this region.
		/// </summary>
		// Token: 0x0601C121 RID: 114977 RVA: 0x0027578B File Offset: 0x0027398B
		public virtual void SetNumberOfPoints(int _arg)
		{
			vtkKdNode.vtkKdNode_SetNumberOfPoints_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C122 RID: 114978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetRight_50(HandleRef pThis, HandleRef right);

		/// <summary>
		/// Set/Get a pointer to the right child of this node.
		/// </summary>
		// Token: 0x0601C123 RID: 114979 RVA: 0x0027579C File Offset: 0x0027399C
		public void SetRight(vtkKdNode right)
		{
			vtkKdNode.vtkKdNode_SetRight_50(base.GetCppThis(), (right == null) ? default(HandleRef) : right.GetCppThis());
		}

		// Token: 0x0601C124 RID: 114980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdNode_SetUp_51(HandleRef pThis, HandleRef up);

		/// <summary>
		/// Set/Get a pointer to the parent of this node.
		/// </summary>
		// Token: 0x0601C125 RID: 114981 RVA: 0x002757CC File Offset: 0x002739CC
		public void SetUp(vtkKdNode up)
		{
			vtkKdNode.vtkKdNode_SetUp_51(base.GetCppThis(), (up == null) ? default(HandleRef) : up.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE1 RID: 7649
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE2 RID: 7650
		public new static readonly string MRClassNameKey = "class vtkKdNode";
	}
}
