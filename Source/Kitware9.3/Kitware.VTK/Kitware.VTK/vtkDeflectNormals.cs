using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDeflectNormals
	/// </summary>
	/// <remarks>
	///    deflect normals using a 3 component vector field
	///
	/// vtkDeflectNormals is a filter that modifies the normals using a vector field.
	/// It is useful to give a 3D perception of a flat surface using shading of the mapper.
	///
	/// The filter passes both its point data and cell data to its output.
	/// </remarks>
	// Token: 0x02000890 RID: 2192
	public class vtkDeflectNormals : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016C24 RID: 93220 RVA: 0x00200107 File Offset: 0x001FE307
		static vtkDeflectNormals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDeflectNormals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDeflectNormals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016C25 RID: 93221 RVA: 0x0020012F File Offset: 0x001FE32F
		public vtkDeflectNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016C26 RID: 93222
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeflectNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C27 RID: 93223 RVA: 0x00200140 File Offset: 0x001FE340
		public new static vtkDeflectNormals New()
		{
			vtkDeflectNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeflectNormals.vtkDeflectNormals_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDeflectNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C28 RID: 93224 RVA: 0x00200194 File Offset: 0x001FE394
		public vtkDeflectNormals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDeflectNormals.vtkDeflectNormals_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016C29 RID: 93225 RVA: 0x002001D8 File Offset: 0x001FE3D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016C2A RID: 93226
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDeflectNormals_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C2B RID: 93227 RVA: 0x002001E4 File Offset: 0x001FE3E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDeflectNormals.vtkDeflectNormals_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016C2C RID: 93228
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDeflectNormals_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C2D RID: 93229 RVA: 0x00200204 File Offset: 0x001FE404
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDeflectNormals.vtkDeflectNormals_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016C2E RID: 93230
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDeflectNormals_GetScaleFactor_03(HandleRef pThis);

		/// <summary>
		/// Specify value to scale deflection.
		/// Default is 1.
		/// </summary>
		// Token: 0x06016C2F RID: 93231 RVA: 0x00200220 File Offset: 0x001FE420
		public virtual double GetScaleFactor()
		{
			return vtkDeflectNormals.vtkDeflectNormals_GetScaleFactor_03(base.GetCppThis());
		}

		// Token: 0x06016C30 RID: 93232
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDeflectNormals_GetUseUserNormal_04(HandleRef pThis);

		/// <summary>
		/// Specify value of the user defined normal.
		/// Default is false.
		/// </summary>
		// Token: 0x06016C31 RID: 93233 RVA: 0x00200240 File Offset: 0x001FE440
		public virtual bool GetUseUserNormal()
		{
			return vtkDeflectNormals.vtkDeflectNormals_GetUseUserNormal_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06016C32 RID: 93234
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeflectNormals_GetUserNormal_05(HandleRef pThis);

		/// <summary>
		/// Specify user defined normal.
		/// Default is (0, 0, 1).
		/// </summary>
		// Token: 0x06016C33 RID: 93235 RVA: 0x00200268 File Offset: 0x001FE468
		public virtual double[] GetUserNormal()
		{
			IntPtr intPtr = vtkDeflectNormals.vtkDeflectNormals_GetUserNormal_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016C34 RID: 93236
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_GetUserNormal_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify user defined normal.
		/// Default is (0, 0, 1).
		/// </summary>
		// Token: 0x06016C35 RID: 93237 RVA: 0x002002B0 File Offset: 0x001FE4B0
		public virtual void GetUserNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkDeflectNormals.vtkDeflectNormals_GetUserNormal_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016C36 RID: 93238
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_GetUserNormal_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify user defined normal.
		/// Default is (0, 0, 1).
		/// </summary>
		// Token: 0x06016C37 RID: 93239 RVA: 0x002002C2 File Offset: 0x001FE4C2
		public virtual void GetUserNormal(IntPtr _arg)
		{
			vtkDeflectNormals.vtkDeflectNormals_GetUserNormal_07(base.GetCppThis(), _arg);
		}

		// Token: 0x06016C38 RID: 93240
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDeflectNormals_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C39 RID: 93241 RVA: 0x002002D4 File Offset: 0x001FE4D4
		public override int IsA(string type)
		{
			return vtkDeflectNormals.vtkDeflectNormals_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06016C3A RID: 93242
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDeflectNormals_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C3B RID: 93243 RVA: 0x002002F4 File Offset: 0x001FE4F4
		public new static int IsTypeOf(string type)
		{
			return vtkDeflectNormals.vtkDeflectNormals_IsTypeOf_09(type);
		}

		// Token: 0x06016C3C RID: 93244
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeflectNormals_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C3D RID: 93245 RVA: 0x00200310 File Offset: 0x001FE510
		public new vtkDeflectNormals NewInstance()
		{
			vtkDeflectNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeflectNormals.vtkDeflectNormals_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDeflectNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016C3E RID: 93246
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeflectNormals_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C3F RID: 93247 RVA: 0x0020036C File Offset: 0x001FE56C
		public new static vtkDeflectNormals SafeDownCast(vtkObjectBase o)
		{
			vtkDeflectNormals vtkDeflectNormals = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeflectNormals.vtkDeflectNormals_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDeflectNormals = (vtkDeflectNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDeflectNormals.Register(null);
				}
			}
			return vtkDeflectNormals;
		}

		// Token: 0x06016C40 RID: 93248
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_SetScaleFactor_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify value to scale deflection.
		/// Default is 1.
		/// </summary>
		// Token: 0x06016C41 RID: 93249 RVA: 0x002003EB File Offset: 0x001FE5EB
		public virtual void SetScaleFactor(double _arg)
		{
			vtkDeflectNormals.vtkDeflectNormals_SetScaleFactor_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06016C42 RID: 93250
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_SetUseUserNormal_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify value of the user defined normal.
		/// Default is false.
		/// </summary>
		// Token: 0x06016C43 RID: 93251 RVA: 0x002003FB File Offset: 0x001FE5FB
		public virtual void SetUseUserNormal(bool _arg)
		{
			vtkDeflectNormals.vtkDeflectNormals_SetUseUserNormal_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016C44 RID: 93252
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_SetUserNormal_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify user defined normal.
		/// Default is (0, 0, 1).
		/// </summary>
		// Token: 0x06016C45 RID: 93253 RVA: 0x00200413 File Offset: 0x001FE613
		public virtual void SetUserNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkDeflectNormals.vtkDeflectNormals_SetUserNormal_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016C46 RID: 93254
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_SetUserNormal_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify user defined normal.
		/// Default is (0, 0, 1).
		/// </summary>
		// Token: 0x06016C47 RID: 93255 RVA: 0x00200425 File Offset: 0x001FE625
		public virtual void SetUserNormal(IntPtr _arg)
		{
			vtkDeflectNormals.vtkDeflectNormals_SetUserNormal_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06016C48 RID: 93256
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_UseUserNormalOff_17(HandleRef pThis);

		/// <summary>
		/// Specify value of the user defined normal.
		/// Default is false.
		/// </summary>
		// Token: 0x06016C49 RID: 93257 RVA: 0x00200435 File Offset: 0x001FE635
		public virtual void UseUserNormalOff()
		{
			vtkDeflectNormals.vtkDeflectNormals_UseUserNormalOff_17(base.GetCppThis());
		}

		// Token: 0x06016C4A RID: 93258
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDeflectNormals_UseUserNormalOn_18(HandleRef pThis);

		/// <summary>
		/// Specify value of the user defined normal.
		/// Default is false.
		/// </summary>
		// Token: 0x06016C4B RID: 93259 RVA: 0x00200444 File Offset: 0x001FE644
		public virtual void UseUserNormalOn()
		{
			vtkDeflectNormals.vtkDeflectNormals_UseUserNormalOn_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001981 RID: 6529
		public new const string MRFullTypeName = "Kitware.VTK.vtkDeflectNormals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001982 RID: 6530
		public new static readonly string MRClassNameKey = "class vtkDeflectNormals";
	}
}
