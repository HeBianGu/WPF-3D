using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumePicker
	/// </summary>
	/// <remarks>
	///    ray-cast picker enhanced for volumes
	///
	/// vtkVolumePicker is a subclass of vtkCellPicker.  It has one
	/// advantage over vtkCellPicker for volumes: it will be able to
	/// correctly perform picking when CroppingPlanes are present.  This
	/// isn't possible for vtkCellPicker since it doesn't link to
	/// the VolumeRendering classes and hence cannot access information
	/// about the CroppingPlanes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPicker vtkPointPicker vtkCellPicker
	///
	/// @par Thanks:
	/// This class was contributed to VTK by David Gobbi on behalf of Atamai Inc.
	/// </seealso>
	// Token: 0x020003AE RID: 942
	public class vtkVolumePicker : vtkCellPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AB9A RID: 43930 RVA: 0x000F3B11 File Offset: 0x000F1D11
		static vtkVolumePicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumePicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumePicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AB9B RID: 43931 RVA: 0x000F3B39 File Offset: 0x000F1D39
		public vtkVolumePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AB9C RID: 43932
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB9D RID: 43933 RVA: 0x000F3B48 File Offset: 0x000F1D48
		public new static vtkVolumePicker New()
		{
			vtkVolumePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumePicker.vtkVolumePicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB9E RID: 43934 RVA: 0x000F3B9C File Offset: 0x000F1D9C
		public vtkVolumePicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumePicker.vtkVolumePicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AB9F RID: 43935 RVA: 0x000F3BE0 File Offset: 0x000F1DE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ABA0 RID: 43936
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumePicker_GetCroppingPlaneId_01(HandleRef pThis);

		/// <summary>
		/// Get the index of the cropping plane that the pick ray passed
		/// through on its way to the prop. This will be set regardless
		/// of whether PickCroppingPlanes is on.  The crop planes are ordered
		/// as follows: xmin, xmax, ymin, ymax, zmin, zmax.  If the volume is
		/// not cropped, the value will bet set to -1.
		/// </summary>
		// Token: 0x0600ABA1 RID: 43937 RVA: 0x000F3BEC File Offset: 0x000F1DEC
		public virtual int GetCroppingPlaneId()
		{
			return vtkVolumePicker.vtkVolumePicker_GetCroppingPlaneId_01(base.GetCppThis());
		}

		// Token: 0x0600ABA2 RID: 43938
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumePicker_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABA3 RID: 43939 RVA: 0x000F3C0C File Offset: 0x000F1E0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumePicker.vtkVolumePicker_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600ABA4 RID: 43940
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumePicker_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABA5 RID: 43941 RVA: 0x000F3C2C File Offset: 0x000F1E2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumePicker.vtkVolumePicker_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600ABA6 RID: 43942
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumePicker_GetPickCroppingPlanes_04(HandleRef pThis);

		/// <summary>
		/// Set whether to pick the cropping planes of props that have them.
		/// If this is set, then the pick will be done on the cropping planes
		/// rather than on the data. The GetCroppingPlaneId() method will return
		/// the index of the cropping plane of the volume that was picked.  This
		/// setting is only relevant to the picking of volumes.
		/// </summary>
		// Token: 0x0600ABA7 RID: 43943 RVA: 0x000F3C48 File Offset: 0x000F1E48
		public virtual int GetPickCroppingPlanes()
		{
			return vtkVolumePicker.vtkVolumePicker_GetPickCroppingPlanes_04(base.GetCppThis());
		}

		// Token: 0x0600ABA8 RID: 43944
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumePicker_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABA9 RID: 43945 RVA: 0x000F3C68 File Offset: 0x000F1E68
		public override int IsA(string type)
		{
			return vtkVolumePicker.vtkVolumePicker_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600ABAA RID: 43946
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumePicker_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABAB RID: 43947 RVA: 0x000F3C88 File Offset: 0x000F1E88
		public new static int IsTypeOf(string type)
		{
			return vtkVolumePicker.vtkVolumePicker_IsTypeOf_06(type);
		}

		// Token: 0x0600ABAC RID: 43948
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumePicker_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABAD RID: 43949 RVA: 0x000F3CA4 File Offset: 0x000F1EA4
		public new vtkVolumePicker NewInstance()
		{
			vtkVolumePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumePicker.vtkVolumePicker_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ABAE RID: 43950
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumePicker_PickCroppingPlanesOff_09(HandleRef pThis);

		/// <summary>
		/// Set whether to pick the cropping planes of props that have them.
		/// If this is set, then the pick will be done on the cropping planes
		/// rather than on the data. The GetCroppingPlaneId() method will return
		/// the index of the cropping plane of the volume that was picked.  This
		/// setting is only relevant to the picking of volumes.
		/// </summary>
		// Token: 0x0600ABAF RID: 43951 RVA: 0x000F3CFE File Offset: 0x000F1EFE
		public virtual void PickCroppingPlanesOff()
		{
			vtkVolumePicker.vtkVolumePicker_PickCroppingPlanesOff_09(base.GetCppThis());
		}

		// Token: 0x0600ABB0 RID: 43952
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumePicker_PickCroppingPlanesOn_10(HandleRef pThis);

		/// <summary>
		/// Set whether to pick the cropping planes of props that have them.
		/// If this is set, then the pick will be done on the cropping planes
		/// rather than on the data. The GetCroppingPlaneId() method will return
		/// the index of the cropping plane of the volume that was picked.  This
		/// setting is only relevant to the picking of volumes.
		/// </summary>
		// Token: 0x0600ABB1 RID: 43953 RVA: 0x000F3D0D File Offset: 0x000F1F0D
		public virtual void PickCroppingPlanesOn()
		{
			vtkVolumePicker.vtkVolumePicker_PickCroppingPlanesOn_10(base.GetCppThis());
		}

		// Token: 0x0600ABB2 RID: 43954
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumePicker_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABB3 RID: 43955 RVA: 0x000F3D1C File Offset: 0x000F1F1C
		public new static vtkVolumePicker SafeDownCast(vtkObjectBase o)
		{
			vtkVolumePicker vtkVolumePicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumePicker.vtkVolumePicker_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumePicker = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumePicker.Register(null);
				}
			}
			return vtkVolumePicker;
		}

		// Token: 0x0600ABB4 RID: 43956
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumePicker_SetPickCroppingPlanes_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to pick the cropping planes of props that have them.
		/// If this is set, then the pick will be done on the cropping planes
		/// rather than on the data. The GetCroppingPlaneId() method will return
		/// the index of the cropping plane of the volume that was picked.  This
		/// setting is only relevant to the picking of volumes.
		/// </summary>
		// Token: 0x0600ABB5 RID: 43957 RVA: 0x000F3D9B File Offset: 0x000F1F9B
		public virtual void SetPickCroppingPlanes(int _arg)
		{
			vtkVolumePicker.vtkVolumePicker_SetPickCroppingPlanes_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D91 RID: 3473
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumePicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D92 RID: 3474
		public new static readonly string MRClassNameKey = "class vtkVolumePicker";
	}
}
