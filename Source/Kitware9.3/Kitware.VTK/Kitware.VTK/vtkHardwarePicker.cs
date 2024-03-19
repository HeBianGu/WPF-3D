using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHardwarePicker
	/// </summary>
	/// <remarks>
	///    pick a point or snap to point of an actor/prop using graphics hardware
	///
	/// vtkHardwarePicker is used to pick point or snap to point of an actor/prop given a selection
	/// point (in display coordinates) and a renderer. This class uses graphics hardware/rendering
	/// system to pick rapidly (as compared to using ray casting as does vtkCellPicker and
	/// vtkPointPicker). This class determines the actor/prop pick position, and pick normal in world
	/// coordinates; pointId is determined if snapping is enabled, otherwise the cellId is determined.
	/// if no actor/prop is picked, pick position = camera focal point, and pick normal = camera plane
	/// normal.
	///
	/// @warning This class supports only picking in a screen, and not in VR.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPropPicker vtkPicker vtkWorldPointPicker vtkCellPicker vtkPointPicker
	/// </seealso>
	// Token: 0x020007E6 RID: 2022
	public class vtkHardwarePicker : vtkAbstractPropPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014C5C RID: 85084 RVA: 0x001D65AB File Offset: 0x001D47AB
		static vtkHardwarePicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHardwarePicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHardwarePicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014C5D RID: 85085 RVA: 0x001D65D3 File Offset: 0x001D47D3
		public vtkHardwarePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014C5E RID: 85086
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C5F RID: 85087 RVA: 0x001D65E4 File Offset: 0x001D47E4
		public new static vtkHardwarePicker New()
		{
			vtkHardwarePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwarePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C60 RID: 85088 RVA: 0x001D6638 File Offset: 0x001D4838
		public vtkHardwarePicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHardwarePicker.vtkHardwarePicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014C61 RID: 85089 RVA: 0x001D667C File Offset: 0x001D487C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014C62 RID: 85090
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwarePicker_GetCellId_01(HandleRef pThis);

		/// <summary>
		/// Get the id of the picked cell.
		///
		/// If a prop is picked:
		///
		/// 1) If SnapOnMeshPoint is on, CellId = -1.
		/// 2) If SnapOnMeshPoint is off, the cellId of the prop's dataset will be returned
		///
		/// if a prop is not picked, CellId = -1.
		/// </summary>
		// Token: 0x06014C63 RID: 85091 RVA: 0x001D6688 File Offset: 0x001D4888
		public virtual long GetCellId()
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetCellId_01(base.GetCppThis());
		}

		// Token: 0x06014C64 RID: 85092
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_GetCompositeDataSet_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the composite dataset that was picked (if any). If nothing
		/// was picked or a non-composite data object was picked then nullptr is returned.
		///
		/// Note: Use vtkWeakPointer. This is because the CompositeDataSet may be deleted.
		/// </summary>
		// Token: 0x06014C65 RID: 85093 RVA: 0x001D66A8 File Offset: 0x001D48A8
		public virtual vtkCompositeDataSet GetCompositeDataSet()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_GetCompositeDataSet_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06014C66 RID: 85094
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the dataset that was picked (if any). If nothing
		/// was picked then nullptr is returned.
		///
		/// Note: Use vtkWeakPointer. This is because the DataSet may be deleted.
		/// </summary>
		// Token: 0x06014C67 RID: 85095 RVA: 0x001D6718 File Offset: 0x001D4918
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_GetDataSet_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06014C68 RID: 85096
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwarePicker_GetFlatBlockIndex_04(HandleRef pThis);

		/// <summary>
		/// Get the flat block index of the vtkDataSet in the composite dataset
		/// that was picked (if any). If nothing was picked or a non-composite
		/// data object was picked then -1 is returned.
		/// </summary>
		// Token: 0x06014C69 RID: 85097 RVA: 0x001D6788 File Offset: 0x001D4988
		public virtual long GetFlatBlockIndex()
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetFlatBlockIndex_04(base.GetCppThis());
		}

		// Token: 0x06014C6A RID: 85098
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_GetMapper_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return mapper that was picked (if any).
		///
		/// Note: Use vtkWeakPointer. This is because the Mapper may be deleted.
		/// </summary>
		// Token: 0x06014C6B RID: 85099 RVA: 0x001D67A8 File Offset: 0x001D49A8
		public virtual vtkAbstractMapper3D GetMapper()
		{
			vtkAbstractMapper3D vtkAbstractMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_GetMapper_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper3D = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper3D.Register(null);
				}
			}
			return vtkAbstractMapper3D;
		}

		// Token: 0x06014C6C RID: 85100
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwarePicker_GetNormalFlipped_06(HandleRef pThis);

		/// <summary>
		/// Get if normal is flipped.
		///
		/// The normal will be flipped if point normals don't exist and the angle between the PickedNormal
		/// and the camera plane normal is more than pi / 2.
		/// </summary>
		// Token: 0x06014C6D RID: 85101 RVA: 0x001D6818 File Offset: 0x001D4A18
		public virtual bool GetNormalFlipped()
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetNormalFlipped_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06014C6E RID: 85102
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwarePicker_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C6F RID: 85103 RVA: 0x001D6840 File Offset: 0x001D4A40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06014C70 RID: 85104
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwarePicker_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C71 RID: 85105 RVA: 0x001D6860 File Offset: 0x001D4A60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06014C72 RID: 85106
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_GetPCoords_09(HandleRef pThis);

		/// <summary>
		/// Get the parametric coordinates of the picked cell. PCoords can be used to compute the
		/// weights that are needed to interpolate data values within the cell.
		///
		/// If a prop is picked:
		///
		/// 1) If SnapOnMeshPoint is on, PCoords will be a vector of
		/// std::numeric_limits&lt;double&gt;::quiet_NaN().
		/// 2) If SnapOnMeshPoint is off, PCoords will be extracted and the intersection point of the cell.
		///
		/// if a prop is not picked, PCoords will be a vector of std::numeric_limits&lt;double&gt;::quiet_NaN().
		/// </summary>
		// Token: 0x06014C73 RID: 85107 RVA: 0x001D687C File Offset: 0x001D4A7C
		public virtual double[] GetPCoords()
		{
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_GetPCoords_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014C74 RID: 85108
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwarePicker_GetPCoords_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the parametric coordinates of the picked cell. PCoords can be used to compute the
		/// weights that are needed to interpolate data values within the cell.
		///
		/// If a prop is picked:
		///
		/// 1) If SnapOnMeshPoint is on, PCoords will be a vector of
		/// std::numeric_limits&lt;double&gt;::quiet_NaN().
		/// 2) If SnapOnMeshPoint is off, PCoords will be extracted and the intersection point of the cell.
		///
		/// if a prop is not picked, PCoords will be a vector of std::numeric_limits&lt;double&gt;::quiet_NaN().
		/// </summary>
		// Token: 0x06014C75 RID: 85109 RVA: 0x001D68C4 File Offset: 0x001D4AC4
		public virtual void GetPCoords(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkHardwarePicker.vtkHardwarePicker_GetPCoords_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06014C76 RID: 85110
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwarePicker_GetPCoords_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the parametric coordinates of the picked cell. PCoords can be used to compute the
		/// weights that are needed to interpolate data values within the cell.
		///
		/// If a prop is picked:
		///
		/// 1) If SnapOnMeshPoint is on, PCoords will be a vector of
		/// std::numeric_limits&lt;double&gt;::quiet_NaN().
		/// 2) If SnapOnMeshPoint is off, PCoords will be extracted and the intersection point of the cell.
		///
		/// if a prop is not picked, PCoords will be a vector of std::numeric_limits&lt;double&gt;::quiet_NaN().
		/// </summary>
		// Token: 0x06014C77 RID: 85111 RVA: 0x001D68D6 File Offset: 0x001D4AD6
		public virtual void GetPCoords(IntPtr _arg)
		{
			vtkHardwarePicker.vtkHardwarePicker_GetPCoords_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06014C78 RID: 85112
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_GetPickNormal_12(HandleRef pThis);

		/// <summary>
		/// Get the normal of the point at the PickPosition.
		///
		/// If a prop is picked:
		///
		/// 1) If SnapOnMeshPoint is on, the picked normal will be extracted from the PointData normals, if
		/// they exist, otherwise a vector of std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
		/// 2) If SnapOnMeshPoint is off, the picked normal on the intersected cell will be extracted using
		/// ray intersection, if the ray intersections was successful, otherwise a vector of
		/// std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
		///
		/// if a prop is not picked, the camera plane normal will be returned will be returned.
		/// </summary>
		// Token: 0x06014C79 RID: 85113 RVA: 0x001D68E8 File Offset: 0x001D4AE8
		public virtual double[] GetPickNormal()
		{
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_GetPickNormal_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014C7A RID: 85114
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwarePicker_GetPickNormal_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the normal of the point at the PickPosition.
		///
		/// If a prop is picked:
		///
		/// 1) If SnapOnMeshPoint is on, the picked normal will be extracted from the PointData normals, if
		/// they exist, otherwise a vector of std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
		/// 2) If SnapOnMeshPoint is off, the picked normal on the intersected cell will be extracted using
		/// ray intersection, if the ray intersections was successful, otherwise a vector of
		/// std::numeric_limits&lt;double&gt;::quiet_NaN() will be returned.
		///
		/// if a prop is not picked, the camera plane normal will be returned will be returned.
		/// </summary>
		// Token: 0x06014C7B RID: 85115 RVA: 0x001D6930 File Offset: 0x001D4B30
		public virtual void GetPickNormal(IntPtr data)
		{
			vtkHardwarePicker.vtkHardwarePicker_GetPickNormal_13(base.GetCppThis(), data);
		}

		// Token: 0x06014C7C RID: 85116
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwarePicker_GetPixelTolerance_14(HandleRef pThis);

		/// <summary>
		/// When SnapToMeshPoint is on, this is the pixel tolerance to use when snapping.
		/// Default is 5.
		/// </summary>
		// Token: 0x06014C7D RID: 85117 RVA: 0x001D6940 File Offset: 0x001D4B40
		public virtual int GetPixelTolerance()
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetPixelTolerance_14(base.GetCppThis());
		}

		// Token: 0x06014C7E RID: 85118
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwarePicker_GetPointId_15(HandleRef pThis);

		/// <summary>
		/// Get the id of the picked point.
		///
		/// If a prop is picked:
		///
		/// 1) if SnapOnMeshPoint is on, the pointId of the prop's dataset will be returned
		/// 2) If SnapOnMeshPoint is off, PointId = -1;
		///
		/// If a prop is not picked, PointId = -1;
		/// </summary>
		// Token: 0x06014C7F RID: 85119 RVA: 0x001D6960 File Offset: 0x001D4B60
		public virtual long GetPointId()
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetPointId_15(base.GetCppThis());
		}

		// Token: 0x06014C80 RID: 85120
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHardwarePicker_GetSnapToMeshPoint_16(HandleRef pThis);

		/// <summary>
		/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
		/// Default is off.
		/// </summary>
		// Token: 0x06014C81 RID: 85121 RVA: 0x001D6980 File Offset: 0x001D4B80
		public virtual bool GetSnapToMeshPoint()
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetSnapToMeshPoint_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06014C82 RID: 85122
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwarePicker_GetSubId_17(HandleRef pThis);

		/// <summary>
		/// Get the subId of the picked cell. This is useful, for example, if
		/// the data is made of triangle strips.
		///
		/// If a prop is picked:
		///
		/// 1) If SnapOnMeshPoint is on, SubId = -1.
		/// 2) If SnapOnMeshPoint is off and the picked cell is a triangle strip, the subId of the
		/// intersected triangle will be returned, otherwise SubId = -1.
		///
		/// If a prop is not picked, SubId = -1.
		/// </summary>
		// Token: 0x06014C83 RID: 85123 RVA: 0x001D69A8 File Offset: 0x001D4BA8
		public virtual int GetSubId()
		{
			return vtkHardwarePicker.vtkHardwarePicker_GetSubId_17(base.GetCppThis());
		}

		// Token: 0x06014C84 RID: 85124
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwarePicker_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C85 RID: 85125 RVA: 0x001D69C8 File Offset: 0x001D4BC8
		public override int IsA(string type)
		{
			return vtkHardwarePicker.vtkHardwarePicker_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06014C86 RID: 85126
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwarePicker_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C87 RID: 85127 RVA: 0x001D69E8 File Offset: 0x001D4BE8
		public new static int IsTypeOf(string type)
		{
			return vtkHardwarePicker.vtkHardwarePicker_IsTypeOf_19(type);
		}

		// Token: 0x06014C88 RID: 85128
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C89 RID: 85129 RVA: 0x001D6A04 File Offset: 0x001D4C04
		public new vtkHardwarePicker NewInstance()
		{
			vtkHardwarePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwarePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014C8A RID: 85130
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwarePicker_Pick_22(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		/// <summary>
		/// Perform the pick operation set the PickedProp.
		///
		/// If something is picked, 1 is returned, and PickPosition, PickNormal, and the rest of the
		/// results variables) are extracted from intersection with the PickedProp.
		///
		/// If something is not picked, 0 is returned, and PickPosition and PickNormal are extracted from
		/// the camera's focal plane.
		/// </summary>
		// Token: 0x06014C8B RID: 85131 RVA: 0x001D6A60 File Offset: 0x001D4C60
		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkHardwarePicker.vtkHardwarePicker_Pick_22(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06014C8C RID: 85132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwarePicker_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C8D RID: 85133 RVA: 0x001D6A9C File Offset: 0x001D4C9C
		public new static vtkHardwarePicker SafeDownCast(vtkObjectBase o)
		{
			vtkHardwarePicker vtkHardwarePicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwarePicker.vtkHardwarePicker_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwarePicker = (vtkHardwarePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwarePicker.Register(null);
				}
			}
			return vtkHardwarePicker;
		}

		// Token: 0x06014C8E RID: 85134
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwarePicker_SetPixelTolerance_24(HandleRef pThis, int _arg);

		/// <summary>
		/// When SnapToMeshPoint is on, this is the pixel tolerance to use when snapping.
		/// Default is 5.
		/// </summary>
		// Token: 0x06014C8F RID: 85135 RVA: 0x001D6B1B File Offset: 0x001D4D1B
		public virtual void SetPixelTolerance(int _arg)
		{
			vtkHardwarePicker.vtkHardwarePicker_SetPixelTolerance_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06014C90 RID: 85136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwarePicker_SetSnapToMeshPoint_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
		/// Default is off.
		/// </summary>
		// Token: 0x06014C91 RID: 85137 RVA: 0x001D6B2B File Offset: 0x001D4D2B
		public virtual void SetSnapToMeshPoint(bool _arg)
		{
			vtkHardwarePicker.vtkHardwarePicker_SetSnapToMeshPoint_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014C92 RID: 85138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwarePicker_SnapToMeshPointOff_26(HandleRef pThis);

		/// <summary>
		/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
		/// Default is off.
		/// </summary>
		// Token: 0x06014C93 RID: 85139 RVA: 0x001D6B43 File Offset: 0x001D4D43
		public virtual void SnapToMeshPointOff()
		{
			vtkHardwarePicker.vtkHardwarePicker_SnapToMeshPointOff_26(base.GetCppThis());
		}

		// Token: 0x06014C94 RID: 85140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwarePicker_SnapToMeshPointOn_27(HandleRef pThis);

		/// <summary>
		/// Set/Get if the picker will snap to the closest mesh point or get the actual intersected point.
		/// Default is off.
		/// </summary>
		// Token: 0x06014C95 RID: 85141 RVA: 0x001D6B52 File Offset: 0x001D4D52
		public virtual void SnapToMeshPointOn()
		{
			vtkHardwarePicker.vtkHardwarePicker_SnapToMeshPointOn_27(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001801 RID: 6145
		public new const string MRFullTypeName = "Kitware.VTK.vtkHardwarePicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001802 RID: 6146
		public new static readonly string MRClassNameKey = "class vtkHardwarePicker";
	}
}
