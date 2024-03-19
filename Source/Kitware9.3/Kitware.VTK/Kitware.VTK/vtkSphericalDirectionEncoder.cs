using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphericalDirectionEncoder
	/// </summary>
	/// <remarks>
	///    A direction encoder based on spherical coordinates
	///
	/// vtkSphericalDirectionEncoder is a direction encoder which uses spherical
	/// coordinates for mapping (nx, ny, nz) into an azimuth, elevation pair.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDirectionEncoder
	/// </seealso>
	// Token: 0x020003A1 RID: 929
	public class vtkSphericalDirectionEncoder : vtkDirectionEncoder
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A92B RID: 43307 RVA: 0x000F03D7 File Offset: 0x000EE5D7
		static vtkSphericalDirectionEncoder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphericalDirectionEncoder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphericalDirectionEncoder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A92C RID: 43308 RVA: 0x000F03FF File Offset: 0x000EE5FF
		public vtkSphericalDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A92D RID: 43309
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalDirectionEncoder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the object. Initialize the index table which will be
		/// used to map the normal into a patch on the recursively subdivided
		/// sphere.
		/// </summary>
		// Token: 0x0600A92E RID: 43310 RVA: 0x000F0410 File Offset: 0x000EE610
		public new static vtkSphericalDirectionEncoder New()
		{
			vtkSphericalDirectionEncoder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the object. Initialize the index table which will be
		/// used to map the normal into a patch on the recursively subdivided
		/// sphere.
		/// </summary>
		// Token: 0x0600A92F RID: 43311 RVA: 0x000F0464 File Offset: 0x000EE664
		public vtkSphericalDirectionEncoder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A930 RID: 43312 RVA: 0x000F04A8 File Offset: 0x000EE6A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A931 RID: 43313
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

		/// <summary>
		/// / Given an encoded value, return a pointer to the normal vector
		/// </summary>
		// Token: 0x0600A932 RID: 43314 RVA: 0x000F04B4 File Offset: 0x000EE6B4
		public override float[] GetDecodedGradient(int value)
		{
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetDecodedGradient_01(base.GetCppThis(), value);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A933 RID: 43315
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

		/// <summary>
		/// Get the decoded gradient table. There are
		/// this-&gt;GetNumberOfEncodedDirections() entries in the table, each
		/// containing a normal (direction) vector. This is a flat structure -
		/// 3 times the number of directions floats in an array.
		/// </summary>
		// Token: 0x0600A934 RID: 43316 RVA: 0x000F0500 File Offset: 0x000EE700
		public override IntPtr GetDecodedGradientTable()
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetDecodedGradientTable_02(base.GetCppThis());
		}

		// Token: 0x0600A935 RID: 43317
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Given a normal vector n, return the encoded direction
		/// </summary>
		// Token: 0x0600A936 RID: 43318 RVA: 0x000F0520 File Offset: 0x000EE720
		public override int GetEncodedDirection(IntPtr n)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetEncodedDirection_03(base.GetCppThis(), n);
		}

		// Token: 0x0600A937 RID: 43319
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

		/// <summary>
		/// Return the number of encoded directions
		/// </summary>
		// Token: 0x0600A938 RID: 43320 RVA: 0x000F0540 File Offset: 0x000EE740
		public override int GetNumberOfEncodedDirections()
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetNumberOfEncodedDirections_04(base.GetCppThis());
		}

		// Token: 0x0600A939 RID: 43321
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A93A RID: 43322 RVA: 0x000F0560 File Offset: 0x000EE760
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A93B RID: 43323
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A93C RID: 43324 RVA: 0x000F0580 File Offset: 0x000EE780
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A93D RID: 43325
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalDirectionEncoder_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A93E RID: 43326 RVA: 0x000F059C File Offset: 0x000EE79C
		public override int IsA(string type)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600A93F RID: 43327
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalDirectionEncoder_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A940 RID: 43328 RVA: 0x000F05BC File Offset: 0x000EE7BC
		public new static int IsTypeOf(string type)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_IsTypeOf_08(type);
		}

		// Token: 0x0600A941 RID: 43329
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalDirectionEncoder_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A942 RID: 43330 RVA: 0x000F05D8 File Offset: 0x000EE7D8
		public new vtkSphericalDirectionEncoder NewInstance()
		{
			vtkSphericalDirectionEncoder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A943 RID: 43331
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalDirectionEncoder_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A944 RID: 43332 RVA: 0x000F0634 File Offset: 0x000EE834
		public new static vtkSphericalDirectionEncoder SafeDownCast(vtkObjectBase o)
		{
			vtkSphericalDirectionEncoder vtkSphericalDirectionEncoder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphericalDirectionEncoder = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphericalDirectionEncoder.Register(null);
				}
			}
			return vtkSphericalDirectionEncoder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D77 RID: 3447
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphericalDirectionEncoder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D78 RID: 3448
		public new static readonly string MRClassNameKey = "class vtkSphericalDirectionEncoder";
	}
}
