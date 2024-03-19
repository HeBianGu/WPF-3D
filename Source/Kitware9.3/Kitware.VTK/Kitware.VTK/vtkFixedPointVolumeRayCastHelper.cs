using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointVolumeRayCastHelper
	/// </summary>
	/// <remarks>
	///    An abstract helper that generates images for the volume ray cast mapper
	///
	/// This is the abstract superclass of all helper classes for the
	/// vtkFixedPointVolumeRayCastMapper. This class should not be used directly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFixedPointVolumeRayCastMapper
	/// </seealso>
	// Token: 0x02000396 RID: 918
	public class vtkFixedPointVolumeRayCastHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A72B RID: 42795 RVA: 0x000ED0C3 File Offset: 0x000EB2C3
		static vtkFixedPointVolumeRayCastHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A72C RID: 42796 RVA: 0x000ED0EB File Offset: 0x000EB2EB
		public vtkFixedPointVolumeRayCastHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A72D RID: 42797
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A72E RID: 42798 RVA: 0x000ED0FC File Offset: 0x000EB2FC
		public new static vtkFixedPointVolumeRayCastHelper New()
		{
			vtkFixedPointVolumeRayCastHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A72F RID: 42799 RVA: 0x000ED150 File Offset: 0x000EB350
		public vtkFixedPointVolumeRayCastHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A730 RID: 42800 RVA: 0x000ED194 File Offset: 0x000EB394
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A731 RID: 42801
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastHelper_GenerateImage_01(HandleRef pThis, int arg0, int arg1, HandleRef arg2, HandleRef arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A732 RID: 42802 RVA: 0x000ED1A0 File Offset: 0x000EB3A0
		public virtual void GenerateImage(int arg0, int arg1, vtkVolume arg2, vtkFixedPointVolumeRayCastMapper arg3)
		{
			vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_GenerateImage_01(base.GetCppThis(), arg0, arg1, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), (arg3 == null) ? default(HandleRef) : arg3.GetCppThis());
		}

		// Token: 0x0600A733 RID: 42803
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A734 RID: 42804 RVA: 0x000ED1E8 File Offset: 0x000EB3E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A735 RID: 42805
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastHelper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A736 RID: 42806 RVA: 0x000ED208 File Offset: 0x000EB408
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A737 RID: 42807
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastHelper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A738 RID: 42808 RVA: 0x000ED224 File Offset: 0x000EB424
		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A739 RID: 42809
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastHelper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A73A RID: 42810 RVA: 0x000ED244 File Offset: 0x000EB444
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_IsTypeOf_05(type);
		}

		// Token: 0x0600A73B RID: 42811
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A73C RID: 42812 RVA: 0x000ED260 File Offset: 0x000EB460
		public new vtkFixedPointVolumeRayCastHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A73D RID: 42813
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A73E RID: 42814 RVA: 0x000ED2BC File Offset: 0x000EB4BC
		public new static vtkFixedPointVolumeRayCastHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastHelper vtkFixedPointVolumeRayCastHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastHelper = (vtkFixedPointVolumeRayCastHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D61 RID: 3425
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D62 RID: 3426
		public new static readonly string MRClassNameKey = "class vtkFixedPointVolumeRayCastHelper";
	}
}
