using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEncodedGradientShader
	/// </summary>
	/// <remarks>
	///    Compute shading tables for encoded normals.
	///
	///
	/// vtkEncodedGradientShader computes shading tables for encoded normals
	/// that indicates the amount of diffuse and specular illumination that is
	/// received from all light sources at a surface location with that normal.
	/// For diffuse illumination this is accurate, but for specular illumination
	/// it is approximate for perspective projections since the center view
	/// direction is always used as the view direction. Since the shading table is
	/// dependent on the volume (for the transformation that must be applied to
	/// the normals to put them into world coordinates) there is a shading table
	/// per volume. This is necessary because multiple volumes can share a
	/// volume mapper.
	/// </remarks>
	// Token: 0x02000393 RID: 915
	public class vtkEncodedGradientShader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A67F RID: 42623 RVA: 0x000EC300 File Offset: 0x000EA500
		static vtkEncodedGradientShader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEncodedGradientShader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEncodedGradientShader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A680 RID: 42624 RVA: 0x000EC328 File Offset: 0x000EA528
		public vtkEncodedGradientShader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A681 RID: 42625
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A682 RID: 42626 RVA: 0x000EC338 File Offset: 0x000EA538
		public new static vtkEncodedGradientShader New()
		{
			vtkEncodedGradientShader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEncodedGradientShader.vtkEncodedGradientShader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A683 RID: 42627 RVA: 0x000EC38C File Offset: 0x000EA58C
		public vtkEncodedGradientShader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEncodedGradientShader.vtkEncodedGradientShader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A684 RID: 42628 RVA: 0x000EC3D0 File Offset: 0x000EA5D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A685 RID: 42629
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientShader_GetActiveComponent_01(HandleRef pThis);

		/// <summary>
		/// Set the active component for shading. This component's
		/// ambient / diffuse / specular / specular power values will
		/// be used to create the shading table. The default is 1.0
		/// </summary>
		// Token: 0x0600A686 RID: 42630 RVA: 0x000EC3DC File Offset: 0x000EA5DC
		public virtual int GetActiveComponent()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetActiveComponent_01(base.GetCppThis());
		}

		// Token: 0x0600A687 RID: 42631
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientShader_GetActiveComponentMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set the active component for shading. This component's
		/// ambient / diffuse / specular / specular power values will
		/// be used to create the shading table. The default is 1.0
		/// </summary>
		// Token: 0x0600A688 RID: 42632 RVA: 0x000EC3FC File Offset: 0x000EA5FC
		public virtual int GetActiveComponentMaxValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetActiveComponentMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600A689 RID: 42633
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientShader_GetActiveComponentMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set the active component for shading. This component's
		/// ambient / diffuse / specular / specular power values will
		/// be used to create the shading table. The default is 1.0
		/// </summary>
		// Token: 0x0600A68A RID: 42634 RVA: 0x000EC41C File Offset: 0x000EA61C
		public virtual int GetActiveComponentMinValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetActiveComponentMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600A68B RID: 42635
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_GetBlueDiffuseShadingTable_04(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// Get the red/green/blue shading table.
		/// </summary>
		// Token: 0x0600A68C RID: 42636 RVA: 0x000EC43C File Offset: 0x000EA63C
		public IntPtr GetBlueDiffuseShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetBlueDiffuseShadingTable_04(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A68D RID: 42637
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_GetBlueSpecularShadingTable_05(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// Get the red/green/blue shading table.
		/// </summary>
		// Token: 0x0600A68E RID: 42638 RVA: 0x000EC470 File Offset: 0x000EA670
		public IntPtr GetBlueSpecularShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetBlueSpecularShadingTable_05(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A68F RID: 42639
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_GetGreenDiffuseShadingTable_06(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// Get the red/green/blue shading table.
		/// </summary>
		// Token: 0x0600A690 RID: 42640 RVA: 0x000EC4A4 File Offset: 0x000EA6A4
		public IntPtr GetGreenDiffuseShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetGreenDiffuseShadingTable_06(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A691 RID: 42641
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_GetGreenSpecularShadingTable_07(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// Get the red/green/blue shading table.
		/// </summary>
		// Token: 0x0600A692 RID: 42642 RVA: 0x000EC4D8 File Offset: 0x000EA6D8
		public IntPtr GetGreenSpecularShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetGreenSpecularShadingTable_07(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A693 RID: 42643
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEncodedGradientShader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A694 RID: 42644 RVA: 0x000EC50C File Offset: 0x000EA70C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600A695 RID: 42645
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEncodedGradientShader_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A696 RID: 42646 RVA: 0x000EC52C File Offset: 0x000EA72C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600A697 RID: 42647
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_GetRedDiffuseShadingTable_10(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// Get the red/green/blue shading table.
		/// </summary>
		// Token: 0x0600A698 RID: 42648 RVA: 0x000EC548 File Offset: 0x000EA748
		public IntPtr GetRedDiffuseShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetRedDiffuseShadingTable_10(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A699 RID: 42649
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_GetRedSpecularShadingTable_11(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// Get the red/green/blue shading table.
		/// </summary>
		// Token: 0x0600A69A RID: 42650 RVA: 0x000EC57C File Offset: 0x000EA77C
		public IntPtr GetRedSpecularShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetRedSpecularShadingTable_11(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A69B RID: 42651
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensity_12(HandleRef pThis);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A69C RID: 42652 RVA: 0x000EC5B0 File Offset: 0x000EA7B0
		public virtual float GetZeroNormalDiffuseIntensity()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalDiffuseIntensity_12(base.GetCppThis());
		}

		// Token: 0x0600A69D RID: 42653
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A69E RID: 42654 RVA: 0x000EC5D0 File Offset: 0x000EA7D0
		public virtual float GetZeroNormalDiffuseIntensityMaxValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600A69F RID: 42655
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A6A0 RID: 42656 RVA: 0x000EC5F0 File Offset: 0x000EA7F0
		public virtual float GetZeroNormalDiffuseIntensityMinValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600A6A1 RID: 42657
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensity_15(HandleRef pThis);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A6A2 RID: 42658 RVA: 0x000EC610 File Offset: 0x000EA810
		public virtual float GetZeroNormalSpecularIntensity()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalSpecularIntensity_15(base.GetCppThis());
		}

		// Token: 0x0600A6A3 RID: 42659
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A6A4 RID: 42660 RVA: 0x000EC630 File Offset: 0x000EA830
		public virtual float GetZeroNormalSpecularIntensityMaxValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600A6A5 RID: 42661
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A6A6 RID: 42662 RVA: 0x000EC650 File Offset: 0x000EA850
		public virtual float GetZeroNormalSpecularIntensityMinValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600A6A7 RID: 42663
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientShader_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6A8 RID: 42664 RVA: 0x000EC670 File Offset: 0x000EA870
		public override int IsA(string type)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600A6A9 RID: 42665
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientShader_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6AA RID: 42666 RVA: 0x000EC690 File Offset: 0x000EA890
		public new static int IsTypeOf(string type)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_IsTypeOf_19(type);
		}

		// Token: 0x0600A6AB RID: 42667
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6AC RID: 42668 RVA: 0x000EC6AC File Offset: 0x000EA8AC
		public new vtkEncodedGradientShader NewInstance()
		{
			vtkEncodedGradientShader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEncodedGradientShader.vtkEncodedGradientShader_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A6AD RID: 42669
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientShader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6AE RID: 42670 RVA: 0x000EC708 File Offset: 0x000EA908
		public new static vtkEncodedGradientShader SafeDownCast(vtkObjectBase o)
		{
			vtkEncodedGradientShader vtkEncodedGradientShader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEncodedGradientShader.vtkEncodedGradientShader_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEncodedGradientShader = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEncodedGradientShader.Register(null);
				}
			}
			return vtkEncodedGradientShader;
		}

		// Token: 0x0600A6AF RID: 42671
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientShader_SetActiveComponent_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the active component for shading. This component's
		/// ambient / diffuse / specular / specular power values will
		/// be used to create the shading table. The default is 1.0
		/// </summary>
		// Token: 0x0600A6B0 RID: 42672 RVA: 0x000EC787 File Offset: 0x000EA987
		public virtual void SetActiveComponent(int _arg)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_SetActiveComponent_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A6B1 RID: 42673
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientShader_SetZeroNormalDiffuseIntensity_24(HandleRef pThis, float _arg);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A6B2 RID: 42674 RVA: 0x000EC797 File Offset: 0x000EA997
		public virtual void SetZeroNormalDiffuseIntensity(float _arg)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_SetZeroNormalDiffuseIntensity_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A6B3 RID: 42675
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientShader_SetZeroNormalSpecularIntensity_25(HandleRef pThis, float _arg);

		/// <summary>
		/// Set / Get the intensity diffuse / specular light used for the
		/// zero normals.
		/// </summary>
		// Token: 0x0600A6B4 RID: 42676 RVA: 0x000EC7A7 File Offset: 0x000EA9A7
		public virtual void SetZeroNormalSpecularIntensity(float _arg)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_SetZeroNormalSpecularIntensity_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A6B5 RID: 42677
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientShader_UpdateShadingTable_26(HandleRef pThis, HandleRef ren, HandleRef vol, HandleRef gradest);

		/// <summary>
		/// Cause the shading table to be updated
		/// </summary>
		// Token: 0x0600A6B6 RID: 42678 RVA: 0x000EC7B8 File Offset: 0x000EA9B8
		public void UpdateShadingTable(vtkRenderer ren, vtkVolume vol, vtkEncodedGradientEstimator gradest)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_UpdateShadingTable_26(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (gradest == null) ? default(HandleRef) : gradest.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D5B RID: 3419
		public new const string MRFullTypeName = "Kitware.VTK.vtkEncodedGradientShader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D5C RID: 3420
		public new static readonly string MRClassNameKey = "class vtkEncodedGradientShader";
	}
}
