using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointVolumeRayCastMIPHelper
	/// </summary>
	/// <remarks>
	///    A helper that generates MIP images for the volume ray cast mapper
	///
	/// This is one of the helper classes for the vtkFixedPointVolumeRayCastMapper.
	/// It will generate maximum intensity images.
	/// This class should not be used directly, it is a helper class for
	/// the mapper and has no user-level API.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFixedPointVolumeRayCastMapper
	/// </seealso>
	// Token: 0x0200039C RID: 924
	public class vtkFixedPointVolumeRayCastMIPHelper : vtkFixedPointVolumeRayCastHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A85B RID: 43099 RVA: 0x000EEE51 File Offset: 0x000ED051
		static vtkFixedPointVolumeRayCastMIPHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastMIPHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastMIPHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A85C RID: 43100 RVA: 0x000EEE79 File Offset: 0x000ED079
		public vtkFixedPointVolumeRayCastMIPHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A85D RID: 43101
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMIPHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A85E RID: 43102 RVA: 0x000EEE88 File Offset: 0x000ED088
		public new static vtkFixedPointVolumeRayCastMIPHelper New()
		{
			vtkFixedPointVolumeRayCastMIPHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A85F RID: 43103 RVA: 0x000EEEDC File Offset: 0x000ED0DC
		public vtkFixedPointVolumeRayCastMIPHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A860 RID: 43104 RVA: 0x000EEF20 File Offset: 0x000ED120
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A861 RID: 43105
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMIPHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A862 RID: 43106 RVA: 0x000EEF2C File Offset: 0x000ED12C
		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600A863 RID: 43107
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastMIPHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A864 RID: 43108 RVA: 0x000EEF74 File Offset: 0x000ED174
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A865 RID: 43109
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastMIPHelper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A866 RID: 43110 RVA: 0x000EEF94 File Offset: 0x000ED194
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A867 RID: 43111
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMIPHelper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A868 RID: 43112 RVA: 0x000EEFB0 File Offset: 0x000ED1B0
		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A869 RID: 43113
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMIPHelper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A86A RID: 43114 RVA: 0x000EEFD0 File Offset: 0x000ED1D0
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_IsTypeOf_05(type);
		}

		// Token: 0x0600A86B RID: 43115
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMIPHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A86C RID: 43116 RVA: 0x000EEFEC File Offset: 0x000ED1EC
		public new vtkFixedPointVolumeRayCastMIPHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastMIPHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A86D RID: 43117
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMIPHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A86E RID: 43118 RVA: 0x000EF048 File Offset: 0x000ED248
		public new static vtkFixedPointVolumeRayCastMIPHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastMIPHelper vtkFixedPointVolumeRayCastMIPHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastMIPHelper = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastMIPHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastMIPHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D6D RID: 3437
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastMIPHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D6E RID: 3438
		public new static readonly string MRClassNameKey = "class vtkFixedPointVolumeRayCastMIPHelper";
	}
}
