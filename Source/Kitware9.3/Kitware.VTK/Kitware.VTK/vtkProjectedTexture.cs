using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProjectedTexture
	/// </summary>
	/// <remarks>
	///    assign texture coordinates for a projected texture
	///
	/// vtkProjectedTexture assigns texture coordinates to a dataset as if
	/// the texture was projected from a slide projected located somewhere in the
	/// scene.  Methods are provided to position the projector and aim it at a
	/// location, to set the width of the projector's frustum, and to set the
	/// range of texture coordinates assigned to the dataset.
	///
	/// Objects in the scene that appear behind the projector are also assigned
	/// texture coordinates; the projected image is left-right and top-bottom
	/// flipped, much as a lens' focus flips the rays of light that pass through
	/// it.  A warning is issued if a point in the dataset falls at the focus
	/// of the projector.
	/// </remarks>
	// Token: 0x02000567 RID: 1383
	public class vtkProjectedTexture : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F498 RID: 62616 RVA: 0x0015488D File Offset: 0x00152A8D
		static vtkProjectedTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectedTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F499 RID: 62617 RVA: 0x001548B5 File Offset: 0x00152AB5
		public vtkProjectedTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F49A RID: 62618
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F49B RID: 62619 RVA: 0x001548C4 File Offset: 0x00152AC4
		public new static vtkProjectedTexture New()
		{
			vtkProjectedTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F49C RID: 62620 RVA: 0x00154918 File Offset: 0x00152B18
		public vtkProjectedTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProjectedTexture.vtkProjectedTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F49D RID: 62621 RVA: 0x0015495C File Offset: 0x00152B5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F49E RID: 62622
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_GetAspectRatio_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the aspect ratio of a perpendicular cross-section of the
		/// the projector's frustum.  The aspect ratio consists of three
		/// numbers:  (x, y, z), where x is the width of the
		/// frustum, y is the height, and z is the perpendicular
		/// distance from the focus of the projector.
		///
		/// For example, if the source of the image is a pinhole camera with
		/// view angle A, then you could set x=1, y=1, z=1/tan(A).
		/// </summary>
		// Token: 0x0600F49F RID: 62623 RVA: 0x00154968 File Offset: 0x00152B68
		public virtual double[] GetAspectRatio()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetAspectRatio_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F4A0 RID: 62624
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_GetAspectRatio_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the aspect ratio of a perpendicular cross-section of the
		/// the projector's frustum.  The aspect ratio consists of three
		/// numbers:  (x, y, z), where x is the width of the
		/// frustum, y is the height, and z is the perpendicular
		/// distance from the focus of the projector.
		///
		/// For example, if the source of the image is a pinhole camera with
		/// view angle A, then you could set x=1, y=1, z=1/tan(A).
		/// </summary>
		// Token: 0x0600F4A1 RID: 62625 RVA: 0x001549B0 File Offset: 0x00152BB0
		public virtual void GetAspectRatio(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetAspectRatio_02(base.GetCppThis(), data);
		}

		// Token: 0x0600F4A2 RID: 62626
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTexture_GetCameraMode_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the camera mode of the projection -- pinhole projection or
		/// two mirror projection.
		/// </summary>
		// Token: 0x0600F4A3 RID: 62627 RVA: 0x001549C0 File Offset: 0x00152BC0
		public virtual int GetCameraMode()
		{
			return vtkProjectedTexture.vtkProjectedTexture_GetCameraMode_03(base.GetCppThis());
		}

		// Token: 0x0600F4A4 RID: 62628
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_GetFocalPoint_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the focal point of the projector (a point that lies along
		/// the center axis of the projector's frustum).
		/// </summary>
		// Token: 0x0600F4A5 RID: 62629 RVA: 0x001549E0 File Offset: 0x00152BE0
		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetFocalPoint_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F4A6 RID: 62630
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_GetFocalPoint_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the focal point of the projector (a point that lies along
		/// the center axis of the projector's frustum).
		/// </summary>
		// Token: 0x0600F4A7 RID: 62631 RVA: 0x00154A28 File Offset: 0x00152C28
		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetFocalPoint_05(base.GetCppThis(), data);
		}

		// Token: 0x0600F4A8 RID: 62632
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProjectedTexture_GetMirrorSeparation_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the mirror separation for the two mirror system.
		/// </summary>
		// Token: 0x0600F4A9 RID: 62633 RVA: 0x00154A38 File Offset: 0x00152C38
		public virtual double GetMirrorSeparation()
		{
			return vtkProjectedTexture.vtkProjectedTexture_GetMirrorSeparation_06(base.GetCppThis());
		}

		// Token: 0x0600F4AA RID: 62634
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTexture_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F4AB RID: 62635 RVA: 0x00154A58 File Offset: 0x00152C58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProjectedTexture.vtkProjectedTexture_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600F4AC RID: 62636
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTexture_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F4AD RID: 62637 RVA: 0x00154A78 File Offset: 0x00152C78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProjectedTexture.vtkProjectedTexture_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600F4AE RID: 62638
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_GetOrientation_09(HandleRef pThis);

		/// <summary>
		/// Get the normalized orientation vector of the projector.
		/// </summary>
		// Token: 0x0600F4AF RID: 62639 RVA: 0x00154A94 File Offset: 0x00152C94
		public virtual double[] GetOrientation()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetOrientation_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F4B0 RID: 62640
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_GetOrientation_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the normalized orientation vector of the projector.
		/// </summary>
		// Token: 0x0600F4B1 RID: 62641 RVA: 0x00154ADC File Offset: 0x00152CDC
		public virtual void GetOrientation(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetOrientation_10(base.GetCppThis(), data);
		}

		// Token: 0x0600F4B2 RID: 62642
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_GetPosition_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the focus of the projector.
		/// </summary>
		// Token: 0x0600F4B3 RID: 62643 RVA: 0x00154AEC File Offset: 0x00152CEC
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetPosition_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F4B4 RID: 62644
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_GetPosition_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the position of the focus of the projector.
		/// </summary>
		// Token: 0x0600F4B5 RID: 62645 RVA: 0x00154B34 File Offset: 0x00152D34
		public virtual void GetPosition(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetPosition_12(base.GetCppThis(), data);
		}

		// Token: 0x0600F4B6 RID: 62646
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_GetSRange_13(HandleRef pThis);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4B7 RID: 62647 RVA: 0x00154B44 File Offset: 0x00152D44
		public virtual double[] GetSRange()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetSRange_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F4B8 RID: 62648
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_GetSRange_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4B9 RID: 62649 RVA: 0x00154B8C File Offset: 0x00152D8C
		public virtual void GetSRange(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetSRange_14(base.GetCppThis(), data);
		}

		// Token: 0x0600F4BA RID: 62650
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_GetTRange_15(HandleRef pThis);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4BB RID: 62651 RVA: 0x00154B9C File Offset: 0x00152D9C
		public virtual double[] GetTRange()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetTRange_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F4BC RID: 62652
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_GetTRange_16(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4BD RID: 62653 RVA: 0x00154BE4 File Offset: 0x00152DE4
		public virtual void GetTRange(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetTRange_16(base.GetCppThis(), data);
		}

		// Token: 0x0600F4BE RID: 62654
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_GetUp_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the up vector of the projector.
		/// </summary>
		// Token: 0x0600F4BF RID: 62655 RVA: 0x00154BF4 File Offset: 0x00152DF4
		public virtual double[] GetUp()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetUp_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F4C0 RID: 62656
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_GetUp_18(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the up vector of the projector.
		/// </summary>
		// Token: 0x0600F4C1 RID: 62657 RVA: 0x00154C3C File Offset: 0x00152E3C
		public virtual void GetUp(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetUp_18(base.GetCppThis(), data);
		}

		// Token: 0x0600F4C2 RID: 62658
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTexture_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F4C3 RID: 62659 RVA: 0x00154C4C File Offset: 0x00152E4C
		public override int IsA(string type)
		{
			return vtkProjectedTexture.vtkProjectedTexture_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0600F4C4 RID: 62660
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTexture_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F4C5 RID: 62661 RVA: 0x00154C6C File Offset: 0x00152E6C
		public new static int IsTypeOf(string type)
		{
			return vtkProjectedTexture.vtkProjectedTexture_IsTypeOf_20(type);
		}

		// Token: 0x0600F4C6 RID: 62662
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F4C7 RID: 62663 RVA: 0x00154C88 File Offset: 0x00152E88
		public new vtkProjectedTexture NewInstance()
		{
			vtkProjectedTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F4C8 RID: 62664
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTexture_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F4C9 RID: 62665 RVA: 0x00154CE4 File Offset: 0x00152EE4
		public new static vtkProjectedTexture SafeDownCast(vtkObjectBase o)
		{
			vtkProjectedTexture vtkProjectedTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTexture = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTexture.Register(null);
				}
			}
			return vtkProjectedTexture;
		}

		// Token: 0x0600F4CA RID: 62666
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetAspectRatio_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the aspect ratio of a perpendicular cross-section of the
		/// the projector's frustum.  The aspect ratio consists of three
		/// numbers:  (x, y, z), where x is the width of the
		/// frustum, y is the height, and z is the perpendicular
		/// distance from the focus of the projector.
		///
		/// For example, if the source of the image is a pinhole camera with
		/// view angle A, then you could set x=1, y=1, z=1/tan(A).
		/// </summary>
		// Token: 0x0600F4CB RID: 62667 RVA: 0x00154D63 File Offset: 0x00152F63
		public virtual void SetAspectRatio(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetAspectRatio_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F4CC RID: 62668
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetAspectRatio_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the aspect ratio of a perpendicular cross-section of the
		/// the projector's frustum.  The aspect ratio consists of three
		/// numbers:  (x, y, z), where x is the width of the
		/// frustum, y is the height, and z is the perpendicular
		/// distance from the focus of the projector.
		///
		/// For example, if the source of the image is a pinhole camera with
		/// view angle A, then you could set x=1, y=1, z=1/tan(A).
		/// </summary>
		// Token: 0x0600F4CD RID: 62669 RVA: 0x00154D75 File Offset: 0x00152F75
		public virtual void SetAspectRatio(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetAspectRatio_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F4CE RID: 62670
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetCameraMode_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the camera mode of the projection -- pinhole projection or
		/// two mirror projection.
		/// </summary>
		// Token: 0x0600F4CF RID: 62671 RVA: 0x00154D85 File Offset: 0x00152F85
		public virtual void SetCameraMode(int _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetCameraMode_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F4D0 RID: 62672
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetCameraModeToPinhole_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the camera mode of the projection -- pinhole projection or
		/// two mirror projection.
		/// </summary>
		// Token: 0x0600F4D1 RID: 62673 RVA: 0x00154D95 File Offset: 0x00152F95
		public void SetCameraModeToPinhole()
		{
			vtkProjectedTexture.vtkProjectedTexture_SetCameraModeToPinhole_27(base.GetCppThis());
		}

		// Token: 0x0600F4D2 RID: 62674
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetCameraModeToTwoMirror_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the camera mode of the projection -- pinhole projection or
		/// two mirror projection.
		/// </summary>
		// Token: 0x0600F4D3 RID: 62675 RVA: 0x00154DA4 File Offset: 0x00152FA4
		public void SetCameraModeToTwoMirror()
		{
			vtkProjectedTexture.vtkProjectedTexture_SetCameraModeToTwoMirror_28(base.GetCppThis());
		}

		// Token: 0x0600F4D4 RID: 62676
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetFocalPoint_29(HandleRef pThis, IntPtr focalPoint);

		/// <summary>
		/// Set/Get the focal point of the projector (a point that lies along
		/// the center axis of the projector's frustum).
		/// </summary>
		// Token: 0x0600F4D5 RID: 62677 RVA: 0x00154DB3 File Offset: 0x00152FB3
		public void SetFocalPoint(IntPtr focalPoint)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetFocalPoint_29(base.GetCppThis(), focalPoint);
		}

		// Token: 0x0600F4D6 RID: 62678
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetFocalPoint_30(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the focal point of the projector (a point that lies along
		/// the center axis of the projector's frustum).
		/// </summary>
		// Token: 0x0600F4D7 RID: 62679 RVA: 0x00154DC3 File Offset: 0x00152FC3
		public void SetFocalPoint(double x, double y, double z)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetFocalPoint_30(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600F4D8 RID: 62680
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetMirrorSeparation_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the mirror separation for the two mirror system.
		/// </summary>
		// Token: 0x0600F4D9 RID: 62681 RVA: 0x00154DD5 File Offset: 0x00152FD5
		public virtual void SetMirrorSeparation(double _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetMirrorSeparation_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F4DA RID: 62682
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetPosition_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the position of the focus of the projector.
		/// </summary>
		// Token: 0x0600F4DB RID: 62683 RVA: 0x00154DE5 File Offset: 0x00152FE5
		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetPosition_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F4DC RID: 62684
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetPosition_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position of the focus of the projector.
		/// </summary>
		// Token: 0x0600F4DD RID: 62685 RVA: 0x00154DF7 File Offset: 0x00152FF7
		public virtual void SetPosition(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetPosition_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F4DE RID: 62686
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetSRange_34(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4DF RID: 62687 RVA: 0x00154E07 File Offset: 0x00153007
		public virtual void SetSRange(double _arg1, double _arg2)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetSRange_34(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600F4E0 RID: 62688
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetSRange_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4E1 RID: 62689 RVA: 0x00154E18 File Offset: 0x00153018
		public void SetSRange(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetSRange_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F4E2 RID: 62690
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetTRange_36(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4E3 RID: 62691 RVA: 0x00154E28 File Offset: 0x00153028
		public virtual void SetTRange(double _arg1, double _arg2)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetTRange_36(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600F4E4 RID: 62692
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetTRange_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600F4E5 RID: 62693 RVA: 0x00154E39 File Offset: 0x00153039
		public void SetTRange(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetTRange_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F4E6 RID: 62694
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetUp_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the up vector of the projector.
		/// </summary>
		// Token: 0x0600F4E7 RID: 62695 RVA: 0x00154E49 File Offset: 0x00153049
		public virtual void SetUp(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetUp_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F4E8 RID: 62696
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTexture_SetUp_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the up vector of the projector.
		/// </summary>
		// Token: 0x0600F4E9 RID: 62697 RVA: 0x00154E5B File Offset: 0x0015305B
		public virtual void SetUp(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetUp_39(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011DD RID: 4573
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011DE RID: 4574
		public new static readonly string MRClassNameKey = "class vtkProjectedTexture";
	}
}
