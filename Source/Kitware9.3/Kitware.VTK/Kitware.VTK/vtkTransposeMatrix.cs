using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransposeMatrix
	/// </summary>
	/// <remarks>
	///    Computes the transpose of an input matrix.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x0200069C RID: 1692
	public class vtkTransposeMatrix : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060121CF RID: 74191 RVA: 0x00195CF7 File Offset: 0x00193EF7
		static vtkTransposeMatrix()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransposeMatrix.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransposeMatrix"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060121D0 RID: 74192 RVA: 0x00195D1F File Offset: 0x00193F1F
		public vtkTransposeMatrix(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060121D1 RID: 74193
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransposeMatrix_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121D2 RID: 74194 RVA: 0x00195D30 File Offset: 0x00193F30
		public new static vtkTransposeMatrix New()
		{
			vtkTransposeMatrix result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransposeMatrix.vtkTransposeMatrix_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransposeMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121D3 RID: 74195 RVA: 0x00195D84 File Offset: 0x00193F84
		public vtkTransposeMatrix() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransposeMatrix.vtkTransposeMatrix_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060121D4 RID: 74196 RVA: 0x00195DC8 File Offset: 0x00193FC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060121D5 RID: 74197
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransposeMatrix_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121D6 RID: 74198 RVA: 0x00195DD4 File Offset: 0x00193FD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransposeMatrix.vtkTransposeMatrix_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060121D7 RID: 74199
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransposeMatrix_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121D8 RID: 74200 RVA: 0x00195DF4 File Offset: 0x00193FF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransposeMatrix.vtkTransposeMatrix_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060121D9 RID: 74201
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransposeMatrix_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121DA RID: 74202 RVA: 0x00195E10 File Offset: 0x00194010
		public override int IsA(string type)
		{
			return vtkTransposeMatrix.vtkTransposeMatrix_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060121DB RID: 74203
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransposeMatrix_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121DC RID: 74204 RVA: 0x00195E30 File Offset: 0x00194030
		public new static int IsTypeOf(string type)
		{
			return vtkTransposeMatrix.vtkTransposeMatrix_IsTypeOf_04(type);
		}

		// Token: 0x060121DD RID: 74205
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransposeMatrix_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121DE RID: 74206 RVA: 0x00195E4C File Offset: 0x0019404C
		public new vtkTransposeMatrix NewInstance()
		{
			vtkTransposeMatrix result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransposeMatrix.vtkTransposeMatrix_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransposeMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060121DF RID: 74207
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransposeMatrix_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121E0 RID: 74208 RVA: 0x00195EA8 File Offset: 0x001940A8
		public new static vtkTransposeMatrix SafeDownCast(vtkObjectBase o)
		{
			vtkTransposeMatrix vtkTransposeMatrix = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransposeMatrix.vtkTransposeMatrix_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransposeMatrix = (vtkTransposeMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransposeMatrix.Register(null);
				}
			}
			return vtkTransposeMatrix;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014E6 RID: 5350
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransposeMatrix";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014E7 RID: 5351
		public new static readonly string MRClassNameKey = "class vtkTransposeMatrix";
	}
}
