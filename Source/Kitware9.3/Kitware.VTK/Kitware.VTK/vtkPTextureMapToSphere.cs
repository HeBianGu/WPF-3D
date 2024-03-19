using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPTextureMapToSphere
	/// </summary>
	/// <remarks>
	///    generate texture coordinates by mapping points to sphere
	///
	/// vtkPTextureMapToSphere inherits from vtkTextureMapToSphere to handle multi-processing
	/// environment.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextureMapToPlane vtkTextureMapToCylinder
	/// vtkTransformTexture vtkThresholdTextureCoords
	/// vtkTextureMapToSphere
	/// </seealso>
	// Token: 0x02000535 RID: 1333
	public class vtkPTextureMapToSphere : vtkTextureMapToSphere
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EDEF RID: 60911 RVA: 0x0014BA0D File Offset: 0x00149C0D
		static vtkPTextureMapToSphere()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPTextureMapToSphere.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPTextureMapToSphere"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EDF0 RID: 60912 RVA: 0x0014BA35 File Offset: 0x00149C35
		public vtkPTextureMapToSphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EDF1 RID: 60913
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTextureMapToSphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDF2 RID: 60914 RVA: 0x0014BA44 File Offset: 0x00149C44
		public new static vtkPTextureMapToSphere New()
		{
			vtkPTextureMapToSphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPTextureMapToSphere.vtkPTextureMapToSphere_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDF3 RID: 60915 RVA: 0x0014BA98 File Offset: 0x00149C98
		public vtkPTextureMapToSphere() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPTextureMapToSphere.vtkPTextureMapToSphere_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EDF4 RID: 60916 RVA: 0x0014BADC File Offset: 0x00149CDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EDF5 RID: 60917
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPTextureMapToSphere_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDF6 RID: 60918 RVA: 0x0014BAE8 File Offset: 0x00149CE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPTextureMapToSphere.vtkPTextureMapToSphere_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EDF7 RID: 60919
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPTextureMapToSphere_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDF8 RID: 60920 RVA: 0x0014BB08 File Offset: 0x00149D08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPTextureMapToSphere.vtkPTextureMapToSphere_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EDF9 RID: 60921
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPTextureMapToSphere_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDFA RID: 60922 RVA: 0x0014BB24 File Offset: 0x00149D24
		public override int IsA(string type)
		{
			return vtkPTextureMapToSphere.vtkPTextureMapToSphere_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EDFB RID: 60923
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPTextureMapToSphere_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDFC RID: 60924 RVA: 0x0014BB44 File Offset: 0x00149D44
		public new static int IsTypeOf(string type)
		{
			return vtkPTextureMapToSphere.vtkPTextureMapToSphere_IsTypeOf_04(type);
		}

		// Token: 0x0600EDFD RID: 60925
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTextureMapToSphere_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDFE RID: 60926 RVA: 0x0014BB60 File Offset: 0x00149D60
		public new vtkPTextureMapToSphere NewInstance()
		{
			vtkPTextureMapToSphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPTextureMapToSphere.vtkPTextureMapToSphere_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EDFF RID: 60927
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPTextureMapToSphere_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE00 RID: 60928 RVA: 0x0014BBBC File Offset: 0x00149DBC
		public new static vtkPTextureMapToSphere SafeDownCast(vtkObjectBase o)
		{
			vtkPTextureMapToSphere vtkPTextureMapToSphere = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPTextureMapToSphere.vtkPTextureMapToSphere_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPTextureMapToSphere = (vtkPTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPTextureMapToSphere.Register(null);
				}
			}
			return vtkPTextureMapToSphere;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001162 RID: 4450
		public new const string MRFullTypeName = "Kitware.VTK.vtkPTextureMapToSphere";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001163 RID: 4451
		public new static readonly string MRClassNameKey = "class vtkPTextureMapToSphere";
	}
}
