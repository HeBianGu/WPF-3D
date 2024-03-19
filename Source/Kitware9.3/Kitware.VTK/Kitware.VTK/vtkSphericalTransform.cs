using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphericalTransform
	/// </summary>
	/// <remarks>
	///    spherical to rectangular coords and back
	///
	/// vtkSphericalTransform will convert (r,phi,theta) coordinates to
	/// (x,y,z) coordinates and back again.  The angles are given in radians.
	/// By default, it converts spherical coordinates to rectangular, but
	/// GetInverse() returns a transform that will do the opposite.  The equation
	/// that is used is x = r*sin(phi)*cos(theta), y = r*sin(phi)*sin(theta),
	/// z = r*cos(phi).
	/// @warning
	/// This transform is not well behaved along the line x=y=0 (i.e. along
	/// the z-axis)
	/// </remarks>
	/// <seealso>
	///
	/// vtkCylindricalTransform vtkGeneralTransform
	/// </seealso>
	// Token: 0x02000B0D RID: 2829
	public class vtkSphericalTransform : vtkWarpTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DB91 RID: 121745 RVA: 0x0029F936 File Offset: 0x0029DB36
		static vtkSphericalTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphericalTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphericalTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DB92 RID: 121746 RVA: 0x0029F95E File Offset: 0x0029DB5E
		public vtkSphericalTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DB93 RID: 121747
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB94 RID: 121748 RVA: 0x0029F96C File Offset: 0x0029DB6C
		public new static vtkSphericalTransform New()
		{
			vtkSphericalTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalTransform.vtkSphericalTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB95 RID: 121749 RVA: 0x0029F9C0 File Offset: 0x0029DBC0
		public vtkSphericalTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphericalTransform.vtkSphericalTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DB96 RID: 121750 RVA: 0x0029FA04 File Offset: 0x0029DC04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DB97 RID: 121751
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB98 RID: 121752 RVA: 0x0029FA10 File Offset: 0x0029DC10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphericalTransform.vtkSphericalTransform_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601DB99 RID: 121753
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalTransform_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB9A RID: 121754 RVA: 0x0029FA30 File Offset: 0x0029DC30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphericalTransform.vtkSphericalTransform_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601DB9B RID: 121755
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalTransform_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB9C RID: 121756 RVA: 0x0029FA4C File Offset: 0x0029DC4C
		public override int IsA(string type)
		{
			return vtkSphericalTransform.vtkSphericalTransform_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601DB9D RID: 121757
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalTransform_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB9E RID: 121758 RVA: 0x0029FA6C File Offset: 0x0029DC6C
		public new static int IsTypeOf(string type)
		{
			return vtkSphericalTransform.vtkSphericalTransform_IsTypeOf_04(type);
		}

		// Token: 0x0601DB9F RID: 121759
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalTransform_MakeTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x0601DBA0 RID: 121760 RVA: 0x0029FA88 File Offset: 0x0029DC88
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalTransform.vtkSphericalTransform_MakeTransform_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DBA1 RID: 121761
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalTransform_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBA2 RID: 121762 RVA: 0x0029FAE4 File Offset: 0x0029DCE4
		public new vtkSphericalTransform NewInstance()
		{
			vtkSphericalTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalTransform.vtkSphericalTransform_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DBA3 RID: 121763
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalTransform_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DBA4 RID: 121764 RVA: 0x0029FB40 File Offset: 0x0029DD40
		public new static vtkSphericalTransform SafeDownCast(vtkObjectBase o)
		{
			vtkSphericalTransform vtkSphericalTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalTransform.vtkSphericalTransform_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphericalTransform = (vtkSphericalTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphericalTransform.Register(null);
				}
			}
			return vtkSphericalTransform;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F4B RID: 8011
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphericalTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F4C RID: 8012
		public new static readonly string MRClassNameKey = "class vtkSphericalTransform";
	}
}
