using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTerrainContourLineInterpolator
	/// </summary>
	/// <remarks>
	///    Contour interpolator for DEM data.
	///
	///
	/// vtkTerrainContourLineInterpolator interpolates nodes on height field data.
	/// The class is meant to be used in conjunciton with a vtkContourWidget,
	/// enabling you to draw paths on terrain data. The class internally uses a
	/// vtkProjectedTerrainPath. Users can set kind of interpolation
	/// desired between two node points by setting the modes of the this filter.
	/// For instance:
	///
	/// <code>
	/// contourRepresentation-&gt;SetLineInterpolator(interpolator);
	/// interpolator-&gt;SetImageData( demDataFile );
	/// interpolator-&gt;GetProjector()-&gt;SetProjectionModeToHug();
	/// interpolator-&gt;SetHeightOffset(25.0);
	/// </code>
	///
	/// You are required to set the ImageData to this class as the height-field
	/// image.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTerrainDataPointPlacer vtkProjectedTerrainPath
	/// </seealso>
	// Token: 0x02000384 RID: 900
	public class vtkTerrainContourLineInterpolator : vtkContourLineInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A41B RID: 42011 RVA: 0x000E8811 File Offset: 0x000E6A11
		static vtkTerrainContourLineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTerrainContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTerrainContourLineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A41C RID: 42012 RVA: 0x000E8839 File Offset: 0x000E6A39
		public vtkTerrainContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A41D RID: 42013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A41E RID: 42014 RVA: 0x000E8848 File Offset: 0x000E6A48
		public new static vtkTerrainContourLineInterpolator New()
		{
			vtkTerrainContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A41F RID: 42015 RVA: 0x000E889C File Offset: 0x000E6A9C
		public vtkTerrainContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A420 RID: 42016 RVA: 0x000E88E0 File Offset: 0x000E6AE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A421 RID: 42017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_GetImageData_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the height field data. The height field data is a 2D image. The
		/// scalars in the image represent the height field. This must be set.
		/// </summary>
		// Token: 0x0600A422 RID: 42018 RVA: 0x000E88EC File Offset: 0x000E6AEC
		public virtual vtkImageData GetImageData()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_GetImageData_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600A423 RID: 42019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A424 RID: 42020 RVA: 0x000E895C File Offset: 0x000E6B5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A425 RID: 42021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A426 RID: 42022 RVA: 0x000E897C File Offset: 0x000E6B7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A427 RID: 42023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_GetProjector_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkProjectedTerrainPath operator used to project the terrain
		/// onto the data. This operator has several modes, See the documentation
		/// of vtkProjectedTerrainPath. The default mode is to hug the terrain
		/// data at 0 height offset.
		/// </summary>
		// Token: 0x0600A428 RID: 42024 RVA: 0x000E8998 File Offset: 0x000E6B98
		public virtual vtkProjectedTerrainPath GetProjector()
		{
			vtkProjectedTerrainPath vtkProjectedTerrainPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_GetProjector_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTerrainPath = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTerrainPath.Register(null);
				}
			}
			return vtkProjectedTerrainPath;
		}

		// Token: 0x0600A429 RID: 42025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainContourLineInterpolator_InterpolateLine_05(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		/// <summary>
		/// Interpolate to create lines between contour nodes idx1 and idx2.
		/// Depending on the projection mode, the interpolated line may either
		/// hug the terrain, just connect the two points with a straight line or
		/// a non-occluded interpolation.
		/// Used internally by vtkContourRepresentation.
		/// </summary>
		// Token: 0x0600A42A RID: 42026 RVA: 0x000E8A08 File Offset: 0x000E6C08
		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_InterpolateLine_05(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		// Token: 0x0600A42B RID: 42027
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainContourLineInterpolator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A42C RID: 42028 RVA: 0x000E8A54 File Offset: 0x000E6C54
		public override int IsA(string type)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600A42D RID: 42029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainContourLineInterpolator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A42E RID: 42030 RVA: 0x000E8A74 File Offset: 0x000E6C74
		public new static int IsTypeOf(string type)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_IsTypeOf_07(type);
		}

		// Token: 0x0600A42F RID: 42031
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A430 RID: 42032 RVA: 0x000E8A90 File Offset: 0x000E6C90
		public new vtkTerrainContourLineInterpolator NewInstance()
		{
			vtkTerrainContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A431 RID: 42033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A432 RID: 42034 RVA: 0x000E8AEC File Offset: 0x000E6CEC
		public new static vtkTerrainContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTerrainContourLineInterpolator vtkTerrainContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTerrainContourLineInterpolator = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTerrainContourLineInterpolator.Register(null);
				}
			}
			return vtkTerrainContourLineInterpolator;
		}

		// Token: 0x0600A433 RID: 42035
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTerrainContourLineInterpolator_SetImageData_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the height field data. The height field data is a 2D image. The
		/// scalars in the image represent the height field. This must be set.
		/// </summary>
		// Token: 0x0600A434 RID: 42036 RVA: 0x000E8B6C File Offset: 0x000E6D6C
		public virtual void SetImageData(vtkImageData arg0)
		{
			vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_SetImageData_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A435 RID: 42037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainContourLineInterpolator_UpdateNode_12(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		/// <summary>
		/// The interpolator is given a chance to update the node.
		/// Used internally by vtkContourRepresentation
		/// Returns 0 if the node (world position) is unchanged.
		/// </summary>
		// Token: 0x0600A436 RID: 42038 RVA: 0x000E8B9C File Offset: 0x000E6D9C
		public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_UpdateNode_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D1F RID: 3359
		public new const string MRFullTypeName = "Kitware.VTK.vtkTerrainContourLineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D20 RID: 3360
		public new static readonly string MRClassNameKey = "class vtkTerrainContourLineInterpolator";
	}
}
