using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCylindricalTransform
	/// </summary>
	/// <remarks>
	///    cylindrical to rectangular coords and back
	///
	/// vtkCylindricalTransform will convert (r,theta,z) coordinates to
	/// (x,y,z) coordinates and back again.  The angles are given in radians.
	/// By default, it converts cylindrical coordinates to rectangular, but
	/// GetInverse() returns a transform that will do the opposite.  The
	/// equation that is used is x = r*cos(theta), y = r*sin(theta), z = z.
	/// @warning
	/// This transform is not well behaved along the line x=y=0 (i.e. along
	/// the z-axis)
	/// </remarks>
	/// <seealso>
	///
	/// vtkSphericalTransform vtkGeneralTransform
	/// </seealso>
	// Token: 0x02000B06 RID: 2822
	public class vtkCylindricalTransform : vtkWarpTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DA53 RID: 121427 RVA: 0x0029DB6F File Offset: 0x0029BD6F
		static vtkCylindricalTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCylindricalTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCylindricalTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA54 RID: 121428 RVA: 0x0029DB97 File Offset: 0x0029BD97
		public vtkCylindricalTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DA55 RID: 121429
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylindricalTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA56 RID: 121430 RVA: 0x0029DBA8 File Offset: 0x0029BDA8
		public new static vtkCylindricalTransform New()
		{
			vtkCylindricalTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylindricalTransform.vtkCylindricalTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylindricalTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA57 RID: 121431 RVA: 0x0029DBFC File Offset: 0x0029BDFC
		public vtkCylindricalTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCylindricalTransform.vtkCylindricalTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA58 RID: 121432 RVA: 0x0029DC40 File Offset: 0x0029BE40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DA59 RID: 121433
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCylindricalTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA5A RID: 121434 RVA: 0x0029DC4C File Offset: 0x0029BE4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCylindricalTransform.vtkCylindricalTransform_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601DA5B RID: 121435
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCylindricalTransform_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA5C RID: 121436 RVA: 0x0029DC6C File Offset: 0x0029BE6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCylindricalTransform.vtkCylindricalTransform_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601DA5D RID: 121437
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylindricalTransform_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA5E RID: 121438 RVA: 0x0029DC88 File Offset: 0x0029BE88
		public override int IsA(string type)
		{
			return vtkCylindricalTransform.vtkCylindricalTransform_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601DA5F RID: 121439
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylindricalTransform_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA60 RID: 121440 RVA: 0x0029DCA8 File Offset: 0x0029BEA8
		public new static int IsTypeOf(string type)
		{
			return vtkCylindricalTransform.vtkCylindricalTransform_IsTypeOf_04(type);
		}

		// Token: 0x0601DA61 RID: 121441
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylindricalTransform_MakeTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x0601DA62 RID: 121442 RVA: 0x0029DCC4 File Offset: 0x0029BEC4
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylindricalTransform.vtkCylindricalTransform_MakeTransform_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DA63 RID: 121443
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylindricalTransform_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA64 RID: 121444 RVA: 0x0029DD20 File Offset: 0x0029BF20
		public new vtkCylindricalTransform NewInstance()
		{
			vtkCylindricalTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylindricalTransform.vtkCylindricalTransform_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylindricalTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DA65 RID: 121445
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylindricalTransform_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA66 RID: 121446 RVA: 0x0029DD7C File Offset: 0x0029BF7C
		public new static vtkCylindricalTransform SafeDownCast(vtkObjectBase o)
		{
			vtkCylindricalTransform vtkCylindricalTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylindricalTransform.vtkCylindricalTransform_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCylindricalTransform = (vtkCylindricalTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCylindricalTransform.Register(null);
				}
			}
			return vtkCylindricalTransform;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F3D RID: 7997
		public new const string MRFullTypeName = "Kitware.VTK.vtkCylindricalTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F3E RID: 7998
		public new static readonly string MRClassNameKey = "class vtkCylindricalTransform";
	}
}
